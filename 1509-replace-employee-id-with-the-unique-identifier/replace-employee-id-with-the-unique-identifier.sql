/* Write your T-SQL query statement below */
select EmployeeUNI.unique_id as unique_id , Employees.name
from Employees Left Join EmployeeUNI 
on Employees.id = EmployeeUNI.id