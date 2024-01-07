create view LISTING_STUDENT_ASSIGNED_INST
as 
select ds.studentID, ds.firstName + ' ' + ds.lastName 'fullName'
from DISABLED_STUDENT ds inner join INSTRUCTOR_LIST il on ds.studentID = il.studentID 
		inner join INSTRUCTOR i on il.employeeID = i.employeeID