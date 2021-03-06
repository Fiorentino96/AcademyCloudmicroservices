USE [DbTodo]
GO
ALTER TABLE [dbo].[TbTodo] DROP CONSTRAINT [FK_TbTodo_TbStates]
GO
ALTER TABLE [dbo].[TbTodo] DROP CONSTRAINT [DF_TbTodo_State]
GO
ALTER TABLE [dbo].[TbTodo] DROP CONSTRAINT [DF_TbTodo_EstimetedHours]
GO
ALTER TABLE [dbo].[TbTodo] DROP CONSTRAINT [DF_TbTodo_CreatedAt]
GO
/****** Object:  Table [dbo].[TbTodo]    Script Date: 04/02/2022 16:14:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TbTodo]') AND type in (N'U'))
DROP TABLE [dbo].[TbTodo]
GO
/****** Object:  Table [dbo].[TbTodo]    Script Date: 04/02/2022 16:14:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbTodo](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NOT NULL,
	[EstimetedHours] [bigint] NOT NULL,
	[IdState] [bigint] NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_TbTodo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[TbTodo] ADD  CONSTRAINT [DF_TbTodo_CreatedAt]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[TbTodo] ADD  CONSTRAINT [DF_TbTodo_EstimetedHours]  DEFAULT ((0)) FOR [EstimetedHours]
GO
ALTER TABLE [dbo].[TbTodo] ADD  CONSTRAINT [DF_TbTodo_State]  DEFAULT ((0)) FOR [IdState]
GO
ALTER TABLE [dbo].[TbTodo]  WITH CHECK ADD  CONSTRAINT [FK_TbTodo_TbStates] FOREIGN KEY([IdState])
REFERENCES [dbo].[TbStates] ([Id])
GO
ALTER TABLE [dbo].[TbTodo] CHECK CONSTRAINT [FK_TbTodo_TbStates]
GO
