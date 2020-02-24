ALTER VIEW dbo.vzAuditTrailCDC
AS
SELECT * FROM dbo.fzAuditTrailCDC('01/01/2013','12/30/2030',1,1) at