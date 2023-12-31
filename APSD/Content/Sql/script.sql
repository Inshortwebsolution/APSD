USE [APSD_Database]
GO
/****** Object:  Table [dbo].[Student_Tbl]    Script Date: 10/29/2023 14:30:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student_Tbl](
	[Student_Id] [int] IDENTITY(1,1) NOT NULL,
	[Enrollment_Id] [int] NULL,
	[Student_Name] [varchar](250) NULL,
	[Email] [varchar](250) NULL,
	[Mobile] [int] NULL,
	[College] [varchar](250) NULL,
	[Branch] [varchar](250) NULL,
	[Year] [varchar](250) NULL,
	[Aadhaar] [varchar](250) NULL,
	[Technologies_Id] [int] NULL,
	[Registration_Fee] [varchar](250) NULL,
	[Course_Id] [int] NULL,
	[Program] [varchar](250) NULL,
	[Address_ID] [int] NULL,
	[Crd_Date] [datetime] NULL,
	[Crd_By] [varchar](250) NULL,
	[Lmd_Date] [datetime] NULL,
	[Lmd_By] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Student_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Qualification_Tbl]    Script Date: 10/29/2023 14:30:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Qualification_Tbl](
	[Qualfication_Id] [int] IDENTITY(1,1) NOT NULL,
	[Education_Id] [int] NULL,
	[Board] [varchar](250) NULL,
	[Passing_Year] [varchar](250) NULL,
	[Crd_Date] [datetime] NULL,
	[Crd_By] [varchar](250) NULL,
	[Lmd_Date] [datetime] NULL,
	[Lmd_By] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Qualfication_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Login_Tbl]    Script Date: 10/29/2023 14:30:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Login_Tbl](
	[Record_id] [int] IDENTITY(1,1) NOT NULL,
	[User_Id] [int] NULL,
	[Password] [varchar](250) NULL,
	[Type] [varchar](250) NULL,
	[LastLoginDate] [datetime] NULL,
	[Crd_Date] [datetime] NULL,
	[Crd_By] [varchar](250) NULL,
	[Lmd_Date] [datetime] NULL,
	[Lmd_By] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Record_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gallery_Tbl]    Script Date: 10/29/2023 14:30:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gallery_Tbl](
	[Gallery_Title] [varchar](250) NULL,
	[Description] [varchar](500) NULL,
	[File_Path] [varchar](500) NULL,
	[File_Type] [varchar](250) NULL,
	[Crd_Date] [datetime] NULL,
	[Crd_By] [varchar](250) NULL,
	[Lmd_Date] [datetime] NULL,
	[Lmd_By] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FeedBack_Tbl]    Script Date: 10/29/2023 14:30:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FeedBack_Tbl](
	[Feedback_Id] [int] IDENTITY(1,1) NOT NULL,
	[User_ID] [int] NULL,
	[Description] [varchar](250) NULL,
	[Rating] [int] NULL,
	[Crd_Date] [datetime] NULL,
	[Crd_By] [varchar](250) NULL,
	[Lmd_Date] [datetime] NULL,
	[Lmd_By] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Feedback_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Event_Tbl]    Script Date: 10/29/2023 14:30:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Event_Tbl](
	[Event_Id] [int] IDENTITY(1,1) NOT NULL,
	[Event_Tittle] [varchar](250) NULL,
	[Event_Description] [varchar](500) NULL,
	[Join_Date] [datetime] NULL,
	[Exp_Date] [datetime] NULL,
	[Start_Date] [datetime] NULL,
	[End_Date] [datetime] NULL,
	[Fee] [varchar](250) NULL,
	[Total_Sheats] [varchar](250) NULL,
	[Lectures] [varchar](250) NULL,
	[Image] [varchar](250) NULL,
	[Type] [varchar](250) NULL,
	[Crd_Date] [datetime] NULL,
	[Crd_By] [varchar](250) NULL,
	[Lmd_Date] [datetime] NULL,
	[Lmd_By] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
	[ISDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Event_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee_Table]    Script Date: 10/29/2023 14:30:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee_Table](
	[Employee_Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NULL,
	[Email] [varchar](250) NULL,
	[Mobile] [int] NULL,
	[Gender] [varchar](250) NULL,
	[Designation_Id] [int] NULL,
	[Sallery] [varchar](250) NULL,
	[Address_Id] [int] NULL,
	[Profile_Img] [varchar](250) NULL,
	[Qualification_Id] [int] NULL,
	[Crd_Date] [datetime] NULL,
	[Crd_By] [varchar](250) NULL,
	[Lmd_Date] [datetime] NULL,
	[Lmd_By] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Employee_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Education_Tbl]    Script Date: 10/29/2023 14:30:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Education_Tbl](
	[Education_Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](250) NULL,
	[Description] [varchar](250) NULL,
	[Crd_Date] [datetime] NULL,
	[Crd_By] [varchar](250) NULL,
	[Lmd_Date] [datetime] NULL,
	[Lmd_By] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Education_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Designation_Tbl]    Script Date: 10/29/2023 14:30:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Designation_Tbl](
	[Designation_Id] [int] IDENTITY(1,1) NOT NULL,
	[Des_Tittle] [varchar](250) NULL,
	[Des_Description] [varchar](250) NULL,
	[Crd_Date] [datetime] NULL,
	[Crd_By] [varchar](250) NULL,
	[Lmd_Date] [datetime] NULL,
	[Lmd_By] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Designation_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Course_Tbl]    Script Date: 10/29/2023 14:30:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Course_Tbl](
	[Course_Id] [int] IDENTITY(1,1) NOT NULL,
	[Course_Name] [varchar](250) NULL,
	[Course_Description] [varchar](500) NULL,
	[Course_Duration_IN_Dates] [varchar](250) NULL,
	[Course_Image] [varchar](250) NULL,
	[Crd_Date] [datetime] NULL,
	[Crd_By] [varchar](250) NULL,
	[Lmd_Date] [datetime] NULL,
	[Lmd_By] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Course_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Address_Tbl]    Script Date: 10/29/2023 14:30:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Address_Tbl](
	[Address_Id] [int] IDENTITY(1,1) NOT NULL,
	[Country_Id] [int] NULL,
	[State_Id] [int] NULL,
	[District_Id] [int] NULL,
	[PinCode] [int] NULL,
	[Landmark] [varchar](250) NULL,
	[Crd_Date] [datetime] NULL,
	[Crd_By] [varchar](250) NULL,
	[Lmd_Date] [datetime] NULL,
	[Lmd_By] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Address_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
