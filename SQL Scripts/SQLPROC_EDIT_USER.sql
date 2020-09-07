ALTER PROC EDIT_USER
@ID NVARCHAR(50),
@FullName NVARCHAR(100),
@PWD VARCHAR(50),
@UserType NVARCHAR(50)
AS



UPDATE [dbo].[USERS]
   SET 
      [PWD] = @PWD
      ,[UserType] = @UserType
      ,[FullName] = @FullName
 WHERE ID = @ID


