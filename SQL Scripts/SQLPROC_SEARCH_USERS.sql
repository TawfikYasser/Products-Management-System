CREATE PROC SEARCH_USERS
@Criterion nvarchar(50)
AS

SELECT [ID] AS 'اسم المستخدم'
      ,[FullName] AS 'الاسم الكامل'
      ,[PWD] AS 'كلمة السر'
      ,[UserType] AS 'نوع المستخدم'
  FROM [dbo].[USERS]
  WHERE [ID] + [FullName] + [PWD] + [UserType] LIKE '%'+ @Criterion +'%'


