using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FSUsinagem.Filters;
using FSUsinagem.Models;

namespace FSUsinagem.Controllers
{
    [Authorize]
    [ValidateHttpAntiForgeryToken]
    public class TodoController : ApiController
    {
        private FSUsinagemContext db = new FSUsinagemContext();

        // PUT api/Todo/5
        public HttpResponseMessage PutTodoItem(int id, TodoItemDto todoItemDto)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != todoItemDto.TodoItemId)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            TodoItem todoItem = todoItemDto.ToEntity();
            TodoList todoList = db.TodoLists.Find(todoItem.TodoListId);
            if (todoList == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            if (todoList.UserId != User.Identity.Name)
            {
                // Tentando modificar um registro que não pertence ao usuário
                return Request.CreateResponse(HttpStatusCode.Unauthorized);
            }

            // É necessário desanexar para evitar a exceção de chave primária duplicada quando SaveChanges é chamado
            db.Entry(todoList).State = EntityState.Detached;
            db.Entry(todoItem).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST api/Todo
        public HttpResponseMessage PostTodoItem(TodoItemDto todoItemDto)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            TodoList todoList = db.TodoLists.Find(todoItemDto.TodoListId);
            if (todoList == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            if (todoList.UserId != User.Identity.Name)
            {
                // Tentando adicionar um registro que não pertence ao usuário
                return Request.CreateResponse(HttpStatusCode.Unauthorized);
            }

            TodoItem todoItem = todoItemDto.ToEntity();

            // É necessário desanexar para evitar a exceção de referência em loop durante a serialização JSON
            db.Entry(todoList).State = EntityState.Detached;
            db.TodoItems.Add(todoItem);
            db.SaveChanges();
            todoItemDto.TodoItemId = todoItem.TodoItemId;

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, todoItemDto);
            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = todoItemDto.TodoItemId }));
            return response;
        }

        // DELETE api/Todo/5
        public HttpResponseMessage DeleteTodoItem(int id)
        {
            TodoItem todoItem = db.TodoItems.Find(id);
            if (todoItem == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            if (db.Entry(todoItem.TodoList).Entity.UserId != User.Identity.Name)
            {
                // Tentando excluir um registro que não pertence ao usuário
                return Request.CreateResponse(HttpStatusCode.Unauthorized);
            }

            TodoItemDto todoItemDto = new TodoItemDto(todoItem);
            db.TodoItems.Remove(todoItem);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

            return Request.CreateResponse(HttpStatusCode.OK, todoItemDto);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}