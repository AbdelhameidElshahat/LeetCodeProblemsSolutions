# Write your MySQL query statement below
select *
from Cinema 
where id %2 =1 && description != 'boring' 
Order by rating DESC