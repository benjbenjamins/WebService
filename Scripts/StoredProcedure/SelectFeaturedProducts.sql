CREATE PROCEDURE SelectFeaturedProducts
AS
BEGIN
SELECT * FROM Products WHERE Product.CategoryId IN (1,2,3)
END;
