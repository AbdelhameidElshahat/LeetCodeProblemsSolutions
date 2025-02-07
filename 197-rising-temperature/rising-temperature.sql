/* Write your T-SQL query statement below */
select w1.id 
from weather w1 inner join weather w2 
on DATEDIFF(day, w1.recordDate, w2.recordDate) = -1
where w2.temperature < w1.temperature


