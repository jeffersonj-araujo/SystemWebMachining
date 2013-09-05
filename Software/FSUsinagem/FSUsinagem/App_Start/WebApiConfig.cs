using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace FSUsinagem
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Remova a codificação de comentário da seguinte linha de código para habilitar o suporte a consultas de ações com um tipo de retorno IQueryable ou IQueryable<T>.
            // Para evitar o processamento de consultas inesperadas ou mal-intencionadas, use as configurações de validação em QueryableAttribute para validar as consultas de entrada.
            // Para obter mais informações, acesse http://go.microsoft.com/fwlink/?LinkId=279712.
            //config.EnableQuerySupport();

            // Para desativar o rastreio no seu aplicativo, comente ou remova a seguinte linha de código
            // Para obter mais informações, consulte: http://www.asp.net/web-api
            config.EnableSystemDiagnosticsTracing();

            // Use minúsculas concatenadas para dados JSON.
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
