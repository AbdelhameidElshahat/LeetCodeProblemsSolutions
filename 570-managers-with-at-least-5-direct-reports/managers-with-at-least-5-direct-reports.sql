/* Write your T-SQL query statement below */
select name from employee where Id In
(Select managerId   
from employee 
group by managerId   
Having Count(managerId)>=5)