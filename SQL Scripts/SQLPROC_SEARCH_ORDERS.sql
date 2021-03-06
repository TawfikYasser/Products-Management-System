﻿ALTER PROC SEARCH_ORDERS
@Criterion NVARCHAR(100)
AS

SELECT [ID_ORDER] AS 'رقم الفاتورة'
      ,[DATE_ORDER] AS 'تاريخ الفاتورة'
	  ,[FIRST_NAME]+ ' '+[LAST_NAME] AS 'اسم العميل'
	  ,[DESCRIPTION_ORDER] AS 'وصف الفاتورة'
      ,[SALESMAN] AS 'اسم البائع'
  FROM [dbo].[ORDERS]
  INNER JOIN CUSTOMERS ON CUSTOMERS.ID_CUSTOMER = ORDERS.CUSTOMER_ID
  WHERE CONVERT(VARCHAR,[ID_ORDER]) + CONVERT(varchar,[DATE_ORDER]) + 
  [FIRST_NAME] + [LAST_NAME] + [DESCRIPTION_ORDER] + [SALESMAN] LIKE '%' + @Criterion + '%'

