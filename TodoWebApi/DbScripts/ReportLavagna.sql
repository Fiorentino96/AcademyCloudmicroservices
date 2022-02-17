SELECT TOP (100) PERCENT dbo.TbTodo.Title, dbo.TbTodo.Description, dbo.TbTodo.CreatedAt, dbo.TbTodo.EstimetedHours, dbo.TbStates.Name AS State, dbo.TbTodo.Name AS AssignedTo
FROM     dbo.TbTodo INNER JOIN
                  dbo.TbStates ON dbo.TbTodo.State = dbo.TbStates.Id
--WHERE  (dbo.TbTodo.State = 0)
ORDER BY dbo.TbTodo.CreatedAt ASC