USE [DbTodo]
GO

UPDATE [dbo].[TbTodo]
   SET [Title] = <Title, nvarchar(max),>
      ,[Description] = <Description, nvarchar(max),>
      ,[CreatedAt] = <CreatedAt, datetime,>
      ,[EstimetedHours] = <EstimetedHours, bigint,>
      ,[State] = <State, int,>
      ,[Name] = <Name, nvarchar(max),>
 WHERE <Condizioni di ricerca,,>
GO


