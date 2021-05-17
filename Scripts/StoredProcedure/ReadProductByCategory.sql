CREATE PROCEDURE SelectByCategoryId(@Id int)
AS
BEGIN
SELECT * FROM Products WHERE Product.CategoryId = @Id
END;

