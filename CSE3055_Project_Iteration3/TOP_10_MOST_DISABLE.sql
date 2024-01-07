create view TOP_10_MOST_DISABLE
as 
select top 10 ds.studentID, ds.firstName + ' ' + ds.lastName 'fullName', matchedSt.per, p.firstName + ' ' + p.lastName 'parentName' , p.gsm
from DISABLED_STUDENT ds
    inner join (
        select ds.studentID stId, hr.disabilityPercentage per
        from DISABLED_STUDENT ds, HEALTH_REPORT hr
        where hr.healthReportNumber=ds.healthReportNumber
        group by ds.studentID, hr.disabilityPercentage
        ) matchedSt on matchedSt.stId = ds.studentID,
    PARENT p
where p.parentID=ds.parentID
order by matchedSt.per desc