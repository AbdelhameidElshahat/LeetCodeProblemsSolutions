# Write your MySQL query statement below
select r.contest_id ,Round((count(u.user_id) /(select Count(*) from Users ) * 100),2) As percentage 
from Users  u right join  register r
On u.user_id = r.user_id
group by r.contest_id 
Order by percentage DESC , r.contest_id ASC