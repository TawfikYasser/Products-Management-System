CREATE PROC SEARCH_CUSTOMER
@Criterion nvarchar(50)
AS

SELECT [ID_CUSTOMER]
      ,[FIRST_NAME] AS 'الاسم الأول'
      ,[LAST_NAME] AS 'الاسم الثاني'
      ,[TEL] AS 'رقم الهاتف'
      ,[EMAIL]AS 'البريد الإلكتروني'
	  ,[IMAGE_CUSTOMER]
  FROM [dbo].[CUSTOMERS]
	WHERE [FIRST_NAME] + [LAST_NAME] + [TEL] + [EMAIL] LIKE '%' + @Criterion + '%'

