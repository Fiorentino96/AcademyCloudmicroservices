GO
SET IDENTITY_INSERT [dbo].[Todo] ON 

INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimetedHours], [IdState], [Name]) VALUES (3, N'networking e protocolli di rete', NULL, CAST(N'2022-02-04T13:47:39.673' AS DateTime), 2, 30, N'Andrea De Matteis')
INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimetedHours], [IdState], [Name]) VALUES (8, N'Networking virtuale su Azure', NULL, CAST(N'2022-02-04T13:47:39.673' AS DateTime), 1, 30, N'Andrea De Matteis')
INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimetedHours], [IdState], [Name]) VALUES (9, N'Health Check e monitoraggio delle istanze', NULL, CAST(N'2022-02-04T13:52:14.473' AS DateTime), 1, 30, N'Luca Marafioti')
INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimetedHours], [IdState], [Name]) VALUES (10, N'Autoscaling orizzontale e verticale', NULL, CAST(N'2022-02-04T13:54:15.933' AS DateTime), 1, 30, N'Luca Marafioti')
INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimetedHours], [IdState], [Name]) VALUES (11, N'Heavy Virtualization', N'doppione', CAST(N'2022-02-04T10:00:00.000' AS DateTime), 1, 30, N'Chiara')
INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimetedHours], [IdState], [Name]) VALUES (12, N'Heavy Virtualization', N'Autoformazione e file', CAST(N'2022-02-04T10:00:00.000' AS DateTime), 1, 30, N'Chiara Petrocelli')
INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimetedHours], [IdState], [Name]) VALUES (14, N'Virtual Private Cloud', NULL, CAST(N'1900-01-01T00:00:00.000' AS DateTime), 1, 30, N'Claudio Truglia')
INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimetedHours], [IdState], [Name]) VALUES (15, N'Load Balancing interno ed esterno', NULL, CAST(N'2022-02-04T14:09:40.340' AS DateTime), 0, 20, N'Fiorentino Federico')
INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimetedHours], [IdState], [Name]) VALUES (16, N'Virtual Private Cloud', N'Definizione e concetti su Virtual Private Cloud', CAST(N'2022-02-04T15:11:38.000' AS DateTime), 1, 30, N'Rocco Reo')
SET IDENTITY_INSERT [dbo].[Todo] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220204161604_Init', N'6.0.1')
GO
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [Name], [Surname], [Town], [Email]) VALUES (1, N'Rocco', N'Reo', N'San Marzano di San Giuseppe', N'roccoreo6@gmail.com')
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
SET IDENTITY_INSERT [dbo].[Todo] ON 

INSERT [dbo].[Todo] ([Id], [Title], [State], [CreatedAt]) VALUES (1, N'ANDREADM', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Todo] ([Id], [Title], [State], [CreatedAt]) VALUES (4, N'Daniele', 0, CAST(N'2022-02-04T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Todo] ([Id], [Title], [State], [CreatedAt]) VALUES (5, N'ROCCOREO', 0, CAST(N'2022-02-04T17:23:45.0000000' AS DateTime2))
INSERT [dbo].[Todo] ([Id], [Title], [State], [CreatedAt]) VALUES (6, N'LUCA', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Todo] ([Id], [Title], [State], [CreatedAt]) VALUES (7, N'CLAUDIO', 0, CAST(N'2022-02-04T17:20:00.0000000' AS DateTime2))
INSERT [dbo].[Todo] ([Id], [Title], [State], [CreatedAt]) VALUES (8, N'FIORENTINO', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Todo] OFF
GO
