Alter PROC GET_ORDER_DETAILS
@ID_ORDER INT
AS

SELECT [ORDERS_DETAILS].[ID_PRODUCT] AS 'رقم المنتج'
		,[PRODUCTS].LABEL_PRODUCT AS 'اسم المنتج'

      ,[ORDERS_DETAILS].[ID_ORDER] AS 'رقم الفاتورة'
      ,[QTE] AS 'الكمية'
      ,convert(float,[ORDERS_DETAILS].[PRICE]) AS 'الثمن'
      ,convert(float,[AMOUNT]) AS 'المبلغ قبل الخصم'
      ,convert(float,[TOTAL_AMOUNT]) AS 'المبلغ بعد الخصم' 
      ,[DISCOUNT] AS 'الخصم'
	  ,[DATE_ORDER] AS 'تاريخ الفاتورة'
	  ,[DESCRIPTION_ORDER] AS 'وصف الفاتورة'
	  ,[SALESMAN] AS 'اسم البائع'
	  ,[ID_CUSTOMER] AS 'رقم العميل'
	  ,[FIRST_NAME]+' '+[LAST_NAME] AS 'اسم العميل'
	  ,[TEL] AS 'رقم الهاتف'
	  ,[EMAIL] AS 'البريد الإلكتروني'
  FROM [dbo].[ORDERS_DETAILS]
  INNER JOIN ORDERS ON ORDERS.ID_ORDER = ORDERS_DETAILS.ID_ORDER
  INNER JOIN CUSTOMERS ON CUSTOMERS.ID_CUSTOMER = ORDERS.CUSTOMER_ID
  INNER JOIN PRODUCTS ON PRODUCTS.ID_PRODUCT = ORDERS_DETAILS.ID_PRODUCT
  WHERE ORDERS_DETAILS.ID_ORDER = @ID_ORDER
