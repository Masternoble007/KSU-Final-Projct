Select Avg(Measurement.MeasuredValue)
FROM LocalDiabetesdb
WHERE Date_Column >= DATEADD(DAY, -90, GETDATE())