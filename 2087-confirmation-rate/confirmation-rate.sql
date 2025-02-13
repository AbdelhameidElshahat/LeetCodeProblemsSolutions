# Write your MySQL query statement below
/* Write your T-SQL query statement below */

select  signups.user_id , ROUnd(AVG(Case When action = 'confirmed' Then 1 Else 0 END ),2) AS confirmation_rate
from Confirmations c Right join Signups On c.user_id = signups.user_id
group by signups.user_id