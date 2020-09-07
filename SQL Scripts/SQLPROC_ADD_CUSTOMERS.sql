CREATE PROC ADD_CUSTOMERS 
@FIRST_NAME NVARCHAR(25),
@LAST_NAME NVARCHAR(25),
@TEL NCHAR(15),
@EMAIL VARCHAR(25),
@PICUTRE IMAGE,
@Criterion varchar(50)

AS
if @Criterion='with_image'
begin
INSERT INTO [dbo].[CUSTOMERS]
           ([FIRST_NAME]
           ,[LAST_NAME]
           ,[TEL]
           ,[EMAIL]
           ,[IMAGE_CUSTOMER])
     VALUES
           (@FIRST_NAME
           ,@LAST_NAME
           ,@TEL
           ,@EMAIL
           ,@PICUTRE)
end
if @Criterion='without_image'
begin
INSERT INTO [dbo].[CUSTOMERS]
           ([FIRST_NAME]
           ,[LAST_NAME]
           ,[TEL]
           ,[EMAIL])
     VALUES
           (@FIRST_NAME
           ,@LAST_NAME
           ,@TEL
           ,@EMAIL)
end


---


