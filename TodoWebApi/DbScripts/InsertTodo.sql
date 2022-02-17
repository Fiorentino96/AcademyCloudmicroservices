USE [DbTodo]
GO

INSERT INTO [dbo].[TbTodo]
           ([Title]
           ,[Description]
           ,[CreatedAt]
           ,[EstimetedHours]
           ,[State]
           ,[Name])
     VALUES
           (<Title, nvarchar(max),>
           ,<Description, nvarchar(max),>
           ,<CreatedAt, datetime,>
           ,<EstimetedHours, bigint,>
           ,<State, int,>
           ,<Name, nvarchar(max),>)
GO


