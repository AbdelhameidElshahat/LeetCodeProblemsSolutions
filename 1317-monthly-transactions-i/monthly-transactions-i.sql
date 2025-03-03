# Write your MySQL query statement below
select DATE_FORMAT(t.trans_date, '%Y-%m') AS month  ,t.country ,
Count(*) As trans_count , Sum(Case when t.state ='approved' then 1 else 0 end ) as approved_count , sum(amount) as trans_total_amount 
, SUM(CASE WHEN t.state = 'approved' THEN t.amount ELSE 0 END) AS approved_total_amount
from Transactions t 
group by DATE_FORMAT(t.trans_date, '%Y-%m') , t.country