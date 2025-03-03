# Write your MySQL query statement below
select q.query_name ,
Round(AVG(rating/position),2)As quality ,
Round(AVG(rating<3)*100,2) As poor_query_percentage 
from queries q
where q.query_name Is not null
group by q.query_name
