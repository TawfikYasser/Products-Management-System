CREATE PROC DELETE_CUSTOMER
@ID INT
AS
DELETE FROM CUSTOMERS WHERE ID_CUSTOMER = @ID