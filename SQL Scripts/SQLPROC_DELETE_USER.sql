CREATE PROC DELETE_USER
@ID NVARCHAR(50)

AS

DELETE FROM [USERS]
 WHERE ID= @ID


