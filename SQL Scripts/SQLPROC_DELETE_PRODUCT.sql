CREATE PROC DELETE_PRODUCT
@ID NVARCHAR(50)
AS
DELETE FROM PRODUCTS WHERE ID_PRODUCT = @ID