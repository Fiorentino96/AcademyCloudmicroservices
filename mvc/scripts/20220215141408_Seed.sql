GO
SET IDENTITY_INSERT [dbo].[Todo] ON 

INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimatedHours], [State]) VALUES (3, N'networking e protocolli di rete', NULL, CAST(N'2022-02-04T13:47:39.673' AS DateTime), 2, 30)
INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimatedHours], [State]) VALUES (8, N'Networking virtuale su Azure', NULL, CAST(N'2022-02-04T13:47:39.673' AS DateTime), 1, 30)
INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimatedHours], [State]) VALUES (9, N'Health Check e monitoraggio delle istanze', NULL, CAST(N'2022-02-04T13:52:14.473' AS DateTime), 1, 30)
INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimatedHours], [State]) VALUES (10, N'Autoscaling orizzontale e verticale', NULL, CAST(N'2022-02-04T13:54:15.933' AS DateTime), 1, 30)
INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimatedHours], [State]) VALUES (11, N'Heavy Virtualization', N'doppione', CAST(N'2022-02-04T10:00:00.000' AS DateTime), 1, 30)
INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimatedHours], [State]) VALUES (12, N'Heavy Virtualization', N'Autoformazione e file', CAST(N'2022-02-04T10:00:00.000' AS DateTime), 1, 30)
INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimatedHours], [State]) VALUES (14, N'Virtual Private Cloud', NULL, CAST(N'1900-01-01T00:00:00.000' AS DateTime), 1, 30)
INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimatedHours], [State]) VALUES (15, N'Load Balancing interno ed esterno', NULL, CAST(N'2022-02-04T14:09:40.340' AS DateTime), 0, 20)
INSERT [dbo].[Todo] ([Id], [Title], [Description], [CreatedAt], [EstimatedHours], [State]) VALUES (16, N'Virtual Private Cloud', N'Definizione e concetti su Virtual Private Cloud', CAST(N'2022-02-04T15:11:38.000' AS DateTime), 1, 30)
SET IDENTITY_INSERT [dbo].[Todo] OFF
GO

SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [Surname], [Town], [Email]) VALUES (1, N'Rocco', N'Reo', N'San Marzano di San Giuseppe', N'roccoreo6@gmail.com')
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
