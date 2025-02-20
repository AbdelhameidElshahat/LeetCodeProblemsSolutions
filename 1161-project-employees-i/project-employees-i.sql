# Write your MySQL query statement below
select p.project_id,Round(sum(e.experience_years) / Count(e.employee_id),2) As average_years 
from Project p left join Employee e 
on p.employee_id = e.employee_id
group by p.project_id