﻿CREATE TABLE [dbo].[Food]
(
	[FoodId] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(MAX) NOT NULL,
	[Brand] VARCHAR(MAX),
	[Carbs] FLOAT
)