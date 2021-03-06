USE [master]
GO
/****** Object:  Database [FSUsinagem]    Script Date: 09/23/2013 18:32:21 ******/
CREATE DATABASE [FSUsinagem] ON  PRIMARY 
( NAME = N'FSUsinagem', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\FSUsinagem.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FSUsinagem_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\FSUsinagem_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FSUsinagem] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FSUsinagem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FSUsinagem] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [FSUsinagem] SET ANSI_NULLS OFF
GO
ALTER DATABASE [FSUsinagem] SET ANSI_PADDING OFF
GO
ALTER DATABASE [FSUsinagem] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [FSUsinagem] SET ARITHABORT OFF
GO
ALTER DATABASE [FSUsinagem] SET AUTO_CLOSE ON
GO
ALTER DATABASE [FSUsinagem] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [FSUsinagem] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [FSUsinagem] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [FSUsinagem] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [FSUsinagem] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [FSUsinagem] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [FSUsinagem] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [FSUsinagem] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [FSUsinagem] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [FSUsinagem] SET  ENABLE_BROKER
GO
ALTER DATABASE [FSUsinagem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [FSUsinagem] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [FSUsinagem] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [FSUsinagem] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [FSUsinagem] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [FSUsinagem] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [FSUsinagem] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [FSUsinagem] SET  READ_WRITE
GO
ALTER DATABASE [FSUsinagem] SET RECOVERY SIMPLE
GO
ALTER DATABASE [FSUsinagem] SET  MULTI_USER
GO
ALTER DATABASE [FSUsinagem] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [FSUsinagem] SET DB_CHAINING OFF
GO
USE [FSUsinagem]
GO
/****** Object:  Table [dbo].[TiposDeProduto]    Script Date: 09/23/2013 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposDeProduto](
	[TipoDeProdutoId] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.TiposDeProduto] PRIMARY KEY CLUSTERED 
(
	[TipoDeProdutoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposDeEndereco]    Script Date: 09/23/2013 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposDeEndereco](
	[TipoDeEnderecoId] [int] NOT NULL,
	[Descricao] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.TiposDeEndereco] PRIMARY KEY CLUSTERED 
(
	[TipoDeEnderecoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposDeCadastro]    Script Date: 09/23/2013 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposDeCadastro](
	[TipoDeCadastroId] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.TiposDeCadastro] PRIMARY KEY CLUSTERED 
(
	[TipoDeCadastroId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CodigosDeOperacao]    Script Date: 09/23/2013 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodigosDeOperacao](
	[CodigoId] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](max) NOT NULL,
	[Descricao] [nvarchar](max) NOT NULL,
	[Tipo] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.CodigosDeOperacao] PRIMARY KEY CLUSTERED 
(
	[CodigoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bancos]    Script Date: 09/23/2013 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bancos](
	[BancoId] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](max) NOT NULL,
	[Descricao] [nvarchar](max) NOT NULL,
	[Agencia] [nvarchar](max) NOT NULL,
	[ContaCorrente] [nvarchar](max) NOT NULL,
	[SaldoDoBanco] [decimal](18, 2) NULL,
	[DataDoSaldo] [datetime] NULL,
 CONSTRAINT [PK_dbo.Bancos] PRIMARY KEY CLUSTERED 
(
	[BancoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadosDePedido]    Script Date: 09/23/2013 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadosDePedido](
	[EstadoDoPedidoId] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.EstadosDePedido] PRIMARY KEY CLUSTERED 
(
	[EstadoDoPedidoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TodoLists]    Script Date: 09/23/2013 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TodoLists](
	[TodoListId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](max) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.TodoLists] PRIMARY KEY CLUSTERED 
(
	[TodoListId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TodoItems]    Script Date: 09/23/2013 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TodoItems](
	[TodoItemId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[IsDone] [bit] NOT NULL,
	[TodoListId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.TodoItems] PRIMARY KEY CLUSTERED 
(
	[TodoItemId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_TodoListId] ON [dbo].[TodoItems] 
(
	[TodoListId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pessoas]    Script Date: 09/23/2013 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pessoas](
	[PessoaId] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Fone] [nvarchar](max) NULL,
	[Fax] [nvarchar](max) NULL,
	[Celular] [nvarchar](max) NULL,
	[TipoDeCadastroId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Pessoas] PRIMARY KEY CLUSTERED 
(
	[PessoaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_TipoDeCadastroId] ON [dbo].[Pessoas] 
(
	[TipoDeCadastroId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produtos]    Script Date: 09/23/2013 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produtos](
	[ProdutoId] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](max) NOT NULL,
	[Descricao] [nvarchar](max) NOT NULL,
	[ValorDeCusto] [decimal](18, 2) NULL,
	[ValorDeVenda] [decimal](18, 2) NULL,
	[TipoDeProdutoId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Produtos] PRIMARY KEY CLUSTERED 
(
	[ProdutoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_TipoDeProdutoId] ON [dbo].[Produtos] 
(
	[TipoDeProdutoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PessoasJuridica]    Script Date: 09/23/2013 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PessoasJuridica](
	[PessoaId] [int] NOT NULL,
	[Cnpj] [nvarchar](max) NOT NULL,
	[Contato] [nvarchar](max) NULL,
	[InscricaoMunicipal] [nvarchar](max) NULL,
	[InscricaoEstadual] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.PessoasJuridica] PRIMARY KEY CLUSTERED 
(
	[PessoaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_PessoaId] ON [dbo].[PessoasJuridica] 
(
	[PessoaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PessoasFisica]    Script Date: 09/23/2013 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PessoasFisica](
	[PessoaId] [int] NOT NULL,
	[Cpf] [nvarchar](max) NOT NULL,
	[Rg] [nvarchar](max) NULL,
	[OrgaoExpedidor] [nvarchar](max) NULL,
	[DataDeNascimento] [datetime] NULL,
 CONSTRAINT [PK_dbo.PessoasFisica] PRIMARY KEY CLUSTERED 
(
	[PessoaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_PessoaId] ON [dbo].[PessoasFisica] 
(
	[PessoaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enderecos]    Script Date: 09/23/2013 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enderecos](
	[EnderecoId] [int] IDENTITY(1,1) NOT NULL,
	[Cep] [nvarchar](max) NULL,
	[TipoDeLogradouro] [nvarchar](max) NULL,
	[Logradouro] [nvarchar](max) NULL,
	[Numero] [nvarchar](max) NULL,
	[Complemento] [nvarchar](max) NULL,
	[Bairro] [nvarchar](max) NULL,
	[Municipio] [nvarchar](max) NULL,
	[Uf] [nvarchar](max) NULL,
	[TipoDeEnderecoId] [int] NOT NULL,
	[Pessoa_PessoaId] [int] NULL,
 CONSTRAINT [PK_dbo.Enderecos] PRIMARY KEY CLUSTERED 
(
	[EnderecoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_Pessoa_PessoaId] ON [dbo].[Enderecos] 
(
	[Pessoa_PessoaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_TipoDeEnderecoId] ON [dbo].[Enderecos] 
(
	[TipoDeEnderecoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_dbo.TodoItems_dbo.TodoLists_TodoListId]    Script Date: 09/23/2013 18:32:24 ******/
ALTER TABLE [dbo].[TodoItems]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TodoItems_dbo.TodoLists_TodoListId] FOREIGN KEY([TodoListId])
REFERENCES [dbo].[TodoLists] ([TodoListId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TodoItems] CHECK CONSTRAINT [FK_dbo.TodoItems_dbo.TodoLists_TodoListId]
GO
/****** Object:  ForeignKey [FK_dbo.Pessoas_dbo.TiposDeCadastro_TipoDeCadastroId]    Script Date: 09/23/2013 18:32:24 ******/
ALTER TABLE [dbo].[Pessoas]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Pessoas_dbo.TiposDeCadastro_TipoDeCadastroId] FOREIGN KEY([TipoDeCadastroId])
REFERENCES [dbo].[TiposDeCadastro] ([TipoDeCadastroId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pessoas] CHECK CONSTRAINT [FK_dbo.Pessoas_dbo.TiposDeCadastro_TipoDeCadastroId]
GO
/****** Object:  ForeignKey [FK_dbo.Produtos_dbo.TiposDeProduto_TipoDeProdutoId]    Script Date: 09/23/2013 18:32:24 ******/
ALTER TABLE [dbo].[Produtos]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Produtos_dbo.TiposDeProduto_TipoDeProdutoId] FOREIGN KEY([TipoDeProdutoId])
REFERENCES [dbo].[TiposDeProduto] ([TipoDeProdutoId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Produtos] CHECK CONSTRAINT [FK_dbo.Produtos_dbo.TiposDeProduto_TipoDeProdutoId]
GO
/****** Object:  ForeignKey [FK_dbo.PessoasJuridica_dbo.Pessoas_PessoaId]    Script Date: 09/23/2013 18:32:24 ******/
ALTER TABLE [dbo].[PessoasJuridica]  WITH CHECK ADD  CONSTRAINT [FK_dbo.PessoasJuridica_dbo.Pessoas_PessoaId] FOREIGN KEY([PessoaId])
REFERENCES [dbo].[Pessoas] ([PessoaId])
GO
ALTER TABLE [dbo].[PessoasJuridica] CHECK CONSTRAINT [FK_dbo.PessoasJuridica_dbo.Pessoas_PessoaId]
GO
/****** Object:  ForeignKey [FK_dbo.PessoasFisica_dbo.Pessoas_PessoaId]    Script Date: 09/23/2013 18:32:24 ******/
ALTER TABLE [dbo].[PessoasFisica]  WITH CHECK ADD  CONSTRAINT [FK_dbo.PessoasFisica_dbo.Pessoas_PessoaId] FOREIGN KEY([PessoaId])
REFERENCES [dbo].[Pessoas] ([PessoaId])
GO
ALTER TABLE [dbo].[PessoasFisica] CHECK CONSTRAINT [FK_dbo.PessoasFisica_dbo.Pessoas_PessoaId]
GO
/****** Object:  ForeignKey [FK_dbo.Enderecos_dbo.Pessoas_Pessoa_PessoaId]    Script Date: 09/23/2013 18:32:24 ******/
ALTER TABLE [dbo].[Enderecos]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Enderecos_dbo.Pessoas_Pessoa_PessoaId] FOREIGN KEY([Pessoa_PessoaId])
REFERENCES [dbo].[Pessoas] ([PessoaId])
GO
ALTER TABLE [dbo].[Enderecos] CHECK CONSTRAINT [FK_dbo.Enderecos_dbo.Pessoas_Pessoa_PessoaId]
GO
/****** Object:  ForeignKey [FK_dbo.Enderecos_dbo.TiposDeEndereco_TipoDeEnderecoId]    Script Date: 09/23/2013 18:32:24 ******/
ALTER TABLE [dbo].[Enderecos]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Enderecos_dbo.TiposDeEndereco_TipoDeEnderecoId] FOREIGN KEY([TipoDeEnderecoId])
REFERENCES [dbo].[TiposDeEndereco] ([TipoDeEnderecoId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Enderecos] CHECK CONSTRAINT [FK_dbo.Enderecos_dbo.TiposDeEndereco_TipoDeEnderecoId]
GO
