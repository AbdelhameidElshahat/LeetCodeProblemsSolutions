# Write your MySQL query statement below
SELECT Students.student_id ,Students.student_name ,Subjects.subject_name  ,Count(Examinations.subject_name) As attended_exams 
FROM Students JOIN Subjects 
Left Join Examinations ON Examinations.student_id  = Students.student_id And Subjects.subject_name  = Examinations.subject_name
Group by 1,2,3
Order by 1 ,3
