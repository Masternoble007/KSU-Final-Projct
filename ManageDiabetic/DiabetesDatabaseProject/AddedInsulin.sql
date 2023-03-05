CREATE TABLE [dbo].[AddedInsulin]
(
	[AddedInsulinId] INTEGER PRIMARY KEY IDENTITY,
	[InsulinId] INTEGER NOT NULL,
	[InsulinAmount] INTEGER NOT NULL,
	FOREIGN KEY (InsulinId) REFERENCES Insulin(InsulinId)
)
