USE [DbTodo]
GO
/****** Object:  View [dbo].[VwGetKanbanStateTodo]    Script Date: 04/02/2022 16:14:59 ******/
DROP VIEW [dbo].[VwGetKanbanStateTodo]
GO
/****** Object:  View [dbo].[VwGetKanbanStateTodo]    Script Date: 04/02/2022 16:14:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VwGetKanbanStateTodo]
AS
SELECT TOP (100) PERCENT dbo.TbTodo.Title, dbo.TbTodo.Description, dbo.TbTodo.CreatedAt, dbo.TbTodo.EstimetedHours, dbo.TbStates.Name AS State, dbo.TbTodo.Name AS AssignedTo
FROM     dbo.TbStates RIGHT OUTER JOIN
                  dbo.TbTodo ON dbo.TbTodo.State = dbo.TbStates.Id
ORDER BY dbo.TbTodo.CreatedAt DESC
GO
