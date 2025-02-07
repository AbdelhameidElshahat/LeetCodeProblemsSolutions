/* Write your T-SQL query statement below */
Select product_id 
From Products
where products.low_fats = 'Y' And products.recyclable  = 'Y'
ORDER BY product_id asc
