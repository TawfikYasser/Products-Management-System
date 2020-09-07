alter PROC GET_ALL_CUSTOMERS
AS 


SELECT [ID_CUSTOMER]
      ,[FIRST_NAME] AS 'الاسم الأول'
      ,[LAST_NAME] AS 'الاسم الثاني'
      ,[TEL] AS 'رقم الهاتف'
      ,[EMAIL]AS 'البريد الإلكتروني'
	  ,[IMAGE_CUSTOMER] as 'صورة العميل'
  FROM [dbo].[CUSTOMERS]

