CREATE TABLE [dbo].[MeasurementFood]
(
	[MeasurementId] INTEGER,
	[FoodId] INTEGER,
	[AmountInGrams] REAL,
	PRIMARY KEY (MeasurementId, FoodId),
	FOREIGN KEY(MeasurementId) REFERENCES Measurement(MeasurementId),
	FOREIGN KEY(FoodId) REFERENCES Food(FoodId)
)
