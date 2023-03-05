CREATE TABLE [dbo].[Measurement]
(
	[MeasurementId] INTEGER PRIMARY KEY IDENTITY(1,1),
	[Date] DATETIME NOT NULL,
	[Time] DATETIME NOT NULL,
	[MeasuredValue] REAL,
	[AddedInsulinId] INTEGER,
	FOREIGN KEY(AddedInsulinId) REFERENCES AddedInsulin(AddedInsulinId)
)
