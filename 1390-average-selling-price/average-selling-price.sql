# Write your MySQL query statement below
select p.product_id ,Coalesce(ROund( Sum(units * price ) / sum(units),2),0) As average_price
from prices p Left join unitsSold u 
ON p.product_id = u.product_id 
And u.purchase_date between p.start_date and p.end_date 
Group by 1 