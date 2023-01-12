USE [TestDatabasePratice]
GO
/****** Object:  Table [dbo].[People]    Script Date: 12/01/2023 10:30:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[Name] [nchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Job] [nchar](100) NULL
) ON [PRIMARY]
GO

INSERT INTO People (Name, Age, Job)
VALUES ("Dan","22","Builder")
,("Rob","34", "Dancer")
,("Zeri","20", "Coder")