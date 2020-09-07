CREATE PROC ADD_USER
@ID NVARCHAR(50),
@FullName NVARCHAR(100),
@PWD VARCHAR(50),
@UserType NVARCHAR(50)
AS

INSERT INTO [dbo].[USERS]
           ([ID]
           ,[PWD]
           ,[UserType]
           ,[FullName])
     VALUES
           (@ID
           ,@PWD
           ,@UserType
           ,@FullName)


