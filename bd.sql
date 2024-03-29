/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [user40]
GO
/****** Object:  Table [dbo].[Collection]    Script Date: 4/23/2019 5:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Collection](
	[CollectionID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CollectorID] [int] NOT NULL,
 CONSTRAINT [PK_Collection] PRIMARY KEY CLUSTERED 
(
	[CollectionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Collector]    Script Date: 4/23/2019 5:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Collector](
	[CollectorID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Lastname] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NULL,
 CONSTRAINT [PK_Collector] PRIMARY KEY CLUSTERED 
(
	[CollectorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mark]    Script Date: 4/23/2019 5:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mark](
	[MarkID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Theme] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NOT NULL,
	[Feature] [nvarchar](max) NULL,
	[IssueDate] [date] NOT NULL,
	[Edition] [int] NOT NULL,
	[PurchaseDate] [date] NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
	[CollectionID] [int] NULL,
 CONSTRAINT [PK_Mark] PRIMARY KEY CLUSTERED 
(
	[MarkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Collection] ON 

INSERT [dbo].[Collection] ([CollectionID], [Name], [CollectorID]) VALUES (1, N'Super', 1)
INSERT [dbo].[Collection] ([CollectionID], [Name], [CollectorID]) VALUES (2, N'Squad', 2)
INSERT [dbo].[Collection] ([CollectionID], [Name], [CollectorID]) VALUES (3, N'Kek', 3)
INSERT [dbo].[Collection] ([CollectionID], [Name], [CollectorID]) VALUES (4, N'gg', 3)
SET IDENTITY_INSERT [dbo].[Collection] OFF
SET IDENTITY_INSERT [dbo].[Collector] ON 

INSERT [dbo].[Collector] ([CollectorID], [Name], [Surname], [Lastname], [Country], [Contact]) VALUES (1, N'Дмитрий', N'Шитов', N'Денисович', N'Россия', N'Hello :)')
INSERT [dbo].[Collector] ([CollectorID], [Name], [Surname], [Lastname], [Country], [Contact]) VALUES (2, N'Владимир', N'Путин', N'Владимирович', N'Испания', N'karnedj')
INSERT [dbo].[Collector] ([CollectorID], [Name], [Surname], [Lastname], [Country], [Contact]) VALUES (3, N'Дмитрий', N'Медведев', N'Анотольевич', N'Украина', N'pidor')
SET IDENTITY_INSERT [dbo].[Collector] OFF
SET IDENTITY_INSERT [dbo].[Mark] ON 

INSERT [dbo].[Mark] ([MarkID], [Name], [Theme], [Country], [Feature], [IssueDate], [Edition], [PurchaseDate], [Price], [CollectionID]) VALUES (1, N'Цветочек', N'Цветы', N'Россия', N'Редкая', CAST(N'2015-07-12' AS Date), 10000, CAST(N'2019-12-12' AS Date), CAST(167.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Mark] ([MarkID], [Name], [Theme], [Country], [Feature], [IssueDate], [Edition], [PurchaseDate], [Price], [CollectionID]) VALUES (2, N'Бегемот', N'Почта', N'Россия', N'Дорогая', CAST(N'2015-12-12' AS Date), 500, CAST(N'2019-04-23' AS Date), CAST(1276.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Mark] ([MarkID], [Name], [Theme], [Country], [Feature], [IssueDate], [Edition], [PurchaseDate], [Price], [CollectionID]) VALUES (3, N'Витаминка', N'Аптека', N'Россия', N'Крутая', CAST(N'2015-12-15' AS Date), 50, CAST(N'2019-06-26' AS Date), CAST(1111.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Mark] ([MarkID], [Name], [Theme], [Country], [Feature], [IssueDate], [Edition], [PurchaseDate], [Price], [CollectionID]) VALUES (4, N'Красотулька', N'Красота', N'Россия', N'Ограниченная', CAST(N'1997-10-16' AS Date), 10, CAST(N'2019-07-30' AS Date), CAST(776.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Mark] ([MarkID], [Name], [Theme], [Country], [Feature], [IssueDate], [Edition], [PurchaseDate], [Price], [CollectionID]) VALUES (5, N'Винни', N'Мультики', N'Россия', N'Старая', CAST(N'1997-10-15' AS Date), 5000, CAST(N'2019-02-24' AS Date), CAST(305.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Mark] ([MarkID], [Name], [Theme], [Country], [Feature], [IssueDate], [Edition], [PurchaseDate], [Price], [CollectionID]) VALUES (6, N'ЛСП', N'Музыка', N'Россия', N'Редкая', CAST(N'2017-12-15' AS Date), 10000, CAST(N'2019-01-01' AS Date), CAST(250.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[Mark] ([MarkID], [Name], [Theme], [Country], [Feature], [IssueDate], [Edition], [PurchaseDate], [Price], [CollectionID]) VALUES (7, N'C#', N'Программирование', N'Россия', N'Редкая', CAST(N'2017-12-15' AS Date), 100, CAST(N'2019-02-02' AS Date), CAST(149.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[Mark] ([MarkID], [Name], [Theme], [Country], [Feature], [IssueDate], [Edition], [PurchaseDate], [Price], [CollectionID]) VALUES (8, N'123456', N'123', N'123', N'123', CAST(N'2019-04-01' AS Date), 123, CAST(N'2019-04-01' AS Date), CAST(1200.00 AS Decimal(10, 2)), 4)
INSERT [dbo].[Mark] ([MarkID], [Name], [Theme], [Country], [Feature], [IssueDate], [Edition], [PurchaseDate], [Price], [CollectionID]) VALUES (9, N'123', N'1233', N'1233', N'1233', CAST(N'2019-04-01' AS Date), 123, CAST(N'2019-04-01' AS Date), CAST(1500.00 AS Decimal(10, 2)), 4)
SET IDENTITY_INSERT [dbo].[Mark] OFF
ALTER TABLE [dbo].[Collection]  WITH CHECK ADD  CONSTRAINT [FK_Collection_Collector] FOREIGN KEY([CollectorID])
REFERENCES [dbo].[Collector] ([CollectorID])
GO
ALTER TABLE [dbo].[Collection] CHECK CONSTRAINT [FK_Collection_Collector]
GO
ALTER TABLE [dbo].[Mark]  WITH CHECK ADD  CONSTRAINT [FK_Mark_Collection] FOREIGN KEY([CollectionID])
REFERENCES [dbo].[Collection] ([CollectionID])
GO
ALTER TABLE [dbo].[Mark] CHECK CONSTRAINT [FK_Mark_Collection]
GO
