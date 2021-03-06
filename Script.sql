USE [AdrianPiecykLab4home]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 03.12.2017 23:09:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NameOfCourse] [nvarchar](50) NULL,
	[ECTSPoints] [int] NULL,
	[CourseHours] [int] NULL,
	[LecturersID] [int] NULL,
	[PlacesID] [int] NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Enrollment]    Script Date: 03.12.2017 23:09:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enrollment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Data] [nvarchar](50) NULL,
	[StudentID] [int] NULL,
	[CoursesID] [int] NULL,
	[LecturersID] [int] NULL,
 CONSTRAINT [PK_Enrollment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lecturers]    Script Date: 03.12.2017 23:09:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lecturers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Degree] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lecturers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Places]    Script Date: 03.12.2017 23:09:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Places](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Building] [nvarchar](50) NULL,
	[RoomNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_Places] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 03.12.2017 23:09:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[StudentNumber] [nvarchar](50) NULL,
	[DateOfBirth] [nvarchar](50) NULL,
	[PESEL] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[NameOfMother] [nvarchar](50) NULL,
	[NameOfFather] [nvarchar](50) NULL,
	[Sex] [nvarchar](50) NULL,
	[PlaceOfResistance] [nvarchar](50) NULL,
	[NumberOfHouse] [nvarchar](50) NULL,
	[Voivodeship] [nvarchar](50) NULL,
	[Street] [nvarchar](50) NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([ID], [NameOfCourse], [ECTSPoints], [CourseHours], [LecturersID], [PlacesID]) VALUES (1, N'Analiza Matematczna 1', 8, 198, NULL, 2)
INSERT [dbo].[Courses] ([ID], [NameOfCourse], [ECTSPoints], [CourseHours], [LecturersID], [PlacesID]) VALUES (2, N'Fizyka 1A', 3, 150, NULL, 4)
INSERT [dbo].[Courses] ([ID], [NameOfCourse], [ECTSPoints], [CourseHours], [LecturersID], [PlacesID]) VALUES (3, N'Angielski', 2, 82, NULL, 9)
INSERT [dbo].[Courses] ([ID], [NameOfCourse], [ECTSPoints], [CourseHours], [LecturersID], [PlacesID]) VALUES (4, N'Algebra', 3, 163, NULL, 10)
INSERT [dbo].[Courses] ([ID], [NameOfCourse], [ECTSPoints], [CourseHours], [LecturersID], [PlacesID]) VALUES (5, N'Grafika Inżynierska', 1, 89, NULL, 8)
INSERT [dbo].[Courses] ([ID], [NameOfCourse], [ECTSPoints], [CourseHours], [LecturersID], [PlacesID]) VALUES (6, N'Podstawy Programowania', 5, 130, NULL, 5)
INSERT [dbo].[Courses] ([ID], [NameOfCourse], [ECTSPoints], [CourseHours], [LecturersID], [PlacesID]) VALUES (7, N'Filozofia', 1, 39, NULL, 1)
INSERT [dbo].[Courses] ([ID], [NameOfCourse], [ECTSPoints], [CourseHours], [LecturersID], [PlacesID]) VALUES (8, N'Systemy Operacyjne', 5, 101, NULL, 7)
INSERT [dbo].[Courses] ([ID], [NameOfCourse], [ECTSPoints], [CourseHours], [LecturersID], [PlacesID]) VALUES (9, N'WF', 2, 30, NULL, 3)
SET IDENTITY_INSERT [dbo].[Courses] OFF
SET IDENTITY_INSERT [dbo].[Lecturers] ON 

INSERT [dbo].[Lecturers] ([ID], [Name], [Surname], [Degree]) VALUES (1, N'Marek', N'Jacon', N'mgr')
INSERT [dbo].[Lecturers] ([ID], [Name], [Surname], [Degree]) VALUES (2, N'Darek', N'Walek', N'dr. ')
INSERT [dbo].[Lecturers] ([ID], [Name], [Surname], [Degree]) VALUES (3, N'Michał', N'Trzmiel', N'dr. hab.')
INSERT [dbo].[Lecturers] ([ID], [Name], [Surname], [Degree]) VALUES (4, N'Zofia', N'Nieruszaj', N'dr.')
INSERT [dbo].[Lecturers] ([ID], [Name], [Surname], [Degree]) VALUES (5, N'Adrian', N'Starosta', N'dr.')
INSERT [dbo].[Lecturers] ([ID], [Name], [Surname], [Degree]) VALUES (6, N'Marian', N'Mały', N'prof.')
INSERT [dbo].[Lecturers] ([ID], [Name], [Surname], [Degree]) VALUES (7, N'Łukasz', N'Remor', N'prof.zwyczajny')
INSERT [dbo].[Lecturers] ([ID], [Name], [Surname], [Degree]) VALUES (8, N'Mirek', N'Jankor', N'dr.')
INSERT [dbo].[Lecturers] ([ID], [Name], [Surname], [Degree]) VALUES (9, N'Halina', N'Fiber', N'dr.')
INSERT [dbo].[Lecturers] ([ID], [Name], [Surname], [Degree]) VALUES (10, N'Max', N'Kolonko', N'prof.')
SET IDENTITY_INSERT [dbo].[Lecturers] OFF
SET IDENTITY_INSERT [dbo].[Places] ON 

INSERT [dbo].[Places] ([ID], [Building], [RoomNumber]) VALUES (1, N'C-5', N'159')
INSERT [dbo].[Places] ([ID], [Building], [RoomNumber]) VALUES (2, N'H-14', N'4D')
INSERT [dbo].[Places] ([ID], [Building], [RoomNumber]) VALUES (3, N'C-13', N'32D')
INSERT [dbo].[Places] ([ID], [Building], [RoomNumber]) VALUES (4, N'A-1', N'51')
INSERT [dbo].[Places] ([ID], [Building], [RoomNumber]) VALUES (5, N'C-13', N'28A')
INSERT [dbo].[Places] ([ID], [Building], [RoomNumber]) VALUES (6, N'A-8', N'48')
INSERT [dbo].[Places] ([ID], [Building], [RoomNumber]) VALUES (7, N'B-14', N'546')
INSERT [dbo].[Places] ([ID], [Building], [RoomNumber]) VALUES (8, N'D-21', N'98')
INSERT [dbo].[Places] ([ID], [Building], [RoomNumber]) VALUES (9, N'E-13', N'745')
INSERT [dbo].[Places] ([ID], [Building], [RoomNumber]) VALUES (10, N'F-2', N'212')
SET IDENTITY_INSERT [dbo].[Places] OFF
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Lecturers] FOREIGN KEY([LecturersID])
REFERENCES [dbo].[Lecturers] ([ID])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Lecturers]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Places] FOREIGN KEY([PlacesID])
REFERENCES [dbo].[Places] ([ID])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Places]
GO
ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_Courses] FOREIGN KEY([CoursesID])
REFERENCES [dbo].[Courses] ([ID])
GO
ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_Enrollment_Courses]
GO
ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_Enrollment] FOREIGN KEY([ID])
REFERENCES [dbo].[Enrollment] ([ID])
GO
ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_Enrollment_Enrollment]
GO
ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_Lecturers] FOREIGN KEY([LecturersID])
REFERENCES [dbo].[Lecturers] ([ID])
GO
ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_Enrollment_Lecturers]
GO
ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([ID])
GO
ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_Enrollment_Students]
GO
