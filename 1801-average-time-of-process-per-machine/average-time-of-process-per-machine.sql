/* Write your T-SQL query statement below */
select a.machine_id , Round(Avg(b.timestamp - a.timestamp ),3) As processing_time 
from Activity a join Activity b ON a.machine_id = b.machine_id 
where a.activity_type= 'start' And b.activity_type = 'end'  And a.process_id = b.process_id
group by a.machine_id