USE [tuyensinh]
GO
/****** Object:  Table [dbo].[Ability]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ability](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ability] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[ParentId] [int] NULL,
	[Description] [nvarchar](500) NULL,
	[Url] [nvarchar](500) NULL,
	[DisplayOrder] [int] NULL,
	[CreateDate] [datetime] NULL,
	[ShowHome] [bit] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Combination]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Combination](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_Combination] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conduct]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Conduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactInfo]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Phone] [int] NULL,
	[Address] [nvarchar](500) NULL,
	[SubjectToId] [int] NULL,
	[BHYT] [int] NULL,
	[StudentId] [int] NULL,
 CONSTRAINT [PK_ContactInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[District]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[District](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[ProvinceId] [int] NOT NULL,
 CONSTRAINT [PK_District] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InfoTHPT]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InfoTHPT](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Province10Id] [int] NULL,
	[Province11Id] [int] NULL,
	[Province12Id] [int] NULL,
	[School10Id] [int] NULL,
	[School11Id] [int] NULL,
	[School12Id] [int] NULL,
	[AbilityId] [int] NULL,
	[ConductId] [int] NULL,
	[Point] [nvarchar](10) NULL,
	[SBD] [nvarchar](50) NULL,
	[HSDDKXT] [nvarchar](50) NULL,
	[Math] [nvarchar](10) NULL,
	[Literature] [nvarchar](10) NULL,
	[English] [nvarchar](10) NULL,
	[Physics] [nvarchar](10) NULL,
	[Chemistry] [nvarchar](10) NULL,
	[Biology] [nvarchar](10) NULL,
	[History] [nvarchar](10) NULL,
	[Geography] [nvarchar](10) NULL,
	[Graduation] [nvarchar](500) NULL,
	[ScoreCard] [nvarchar](500) NULL,
	[StudentId] [int] NULL,
	[Type] [int] NULL,
	[YearGraduation] [int] NULL,
 CONSTRAINT [PK_InfoTHPT] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Major]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Major](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Description] [nvarchar](500) NULL,
	[CreateDate] [datetime] NULL,
	[EditDate] [datetime] NULL,
	[Code] [nvarchar](100) NULL,
	[Combination1] [int] NULL,
	[Combination2] [int] NULL,
	[Combination3] [int] NULL,
	[Combination4] [int] NULL,
 CONSTRAINT [PK_Major] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nation]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_Nation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[News]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[CategoryId] [int] NULL,
	[Image] [nvarchar](500) NULL,
	[Description] [nvarchar](max) NULL,
	[Detail] [nvarchar](max) NULL,
	[IsNew] [bit] NULL,
	[CreateDate] [datetime] NULL,
	[EditDate] [datetime] NULL,
	[Url] [nvarchar](250) NULL,
	[DisplayOrder] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Province]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Province](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Code] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Province] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[CategoryId] [int] NULL,
	[Image] [nvarchar](500) NULL,
	[Description] [nvarchar](max) NULL,
	[Detail] [nvarchar](max) NULL,
	[IsNew] [bit] NULL,
	[CreateDate] [datetime] NULL,
	[EditDate] [datetime] NULL,
	[Url] [nvarchar](250) NULL,
	[DisplayOrder] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[School]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[School](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[ProvinceId] [int] NULL,
	[Code] [int] NULL,
 CONSTRAINT [PK_School] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Phone] [varchar](11) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](250) NOT NULL,
	[DOB] [datetime] NULL,
	[Avatar] [nvarchar](250) NULL,
	[Gender] [int] NULL,
	[Status] [int] NULL,
	[CreateDate] [datetime] NULL,
	[EditDate] [datetime] NULL,
	[NationId] [int] NULL,
	[CMND] [int] NULL,
	[ProvinceId] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubjectTo]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubjectTo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_SubjectTo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ward]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ward](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[DistrictId] [int] NOT NULL,
 CONSTRAINT [PK_Ward] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Wish]    Script Date: 29/05/2022 21:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wish](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Major1Id] [int] NULL,
	[Major2Id] [int] NULL,
	[Combination1Id] [int] NULL,
	[Combination2Id] [int] NULL,
	[Point1] [nvarchar](10) NULL,
	[Point2] [nvarchar](10) NULL,
	[StudentId] [int] NULL,
 CONSTRAINT [PK_Wish] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ability] ON 

INSERT [dbo].[Ability] ([Id], [Name]) VALUES (1, N'Giỏi')
INSERT [dbo].[Ability] ([Id], [Name]) VALUES (2, N'Khá')
INSERT [dbo].[Ability] ([Id], [Name]) VALUES (3, N'Trung bình')
INSERT [dbo].[Ability] ([Id], [Name]) VALUES (4, N'Yếu ')
INSERT [dbo].[Ability] ([Id], [Name]) VALUES (5, N'Kém')
INSERT [dbo].[Ability] ([Id], [Name]) VALUES (6, N'---')
SET IDENTITY_INSERT [dbo].[Ability] OFF
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'630a4bea-2ceb-46ab-b26d-0854287bf13c', N'admin', N'ADMIN', N'admin@gmail.com', N'admin@gmail.com', 1, N'AQAAAAEAACcQAAAAEDVVxU5cqemmkrHx2w7DXR3pSfWcVsm9I0MO+ykCl7NAcXhhfP7Hl5wgaTkSJP85uA==', N'UQUDWAPTGCCH6GAA3ZT6CXR4RKDQA6BX', N'74342c66-d5f1-4ad7-b80c-1df22c2d1c9f', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Description], [Url], [DisplayOrder], [CreateDate], [ShowHome], [Status]) VALUES (2, N'Danh mục 1jjj', 1, N'ko', N'danh-muc-1jjj', 3, CAST(N'2022-03-11T14:18:10.560' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Combination] ON 

INSERT [dbo].[Combination] ([Id], [Name]) VALUES (4, N'Toán, Văn, Anh')
INSERT [dbo].[Combination] ([Id], [Name]) VALUES (5, N'Toán, Lý, Hóa')
INSERT [dbo].[Combination] ([Id], [Name]) VALUES (6, N'Toán, Lý, Anh')
INSERT [dbo].[Combination] ([Id], [Name]) VALUES (7, N'Toán, Hóa, Anh')
INSERT [dbo].[Combination] ([Id], [Name]) VALUES (8, N'Toán, Lý, Văn')
INSERT [dbo].[Combination] ([Id], [Name]) VALUES (9, N'Toán, Văn, Hóa')
INSERT [dbo].[Combination] ([Id], [Name]) VALUES (10, N'Sinh, Sử, Địa')
SET IDENTITY_INSERT [dbo].[Combination] OFF
GO
SET IDENTITY_INSERT [dbo].[Conduct] ON 

INSERT [dbo].[Conduct] ([Id], [Name]) VALUES (1, N'Tốt')
INSERT [dbo].[Conduct] ([Id], [Name]) VALUES (2, N'Khá')
INSERT [dbo].[Conduct] ([Id], [Name]) VALUES (3, N'Trung bình')
INSERT [dbo].[Conduct] ([Id], [Name]) VALUES (4, N'Yếu')
INSERT [dbo].[Conduct] ([Id], [Name]) VALUES (5, N'---')
SET IDENTITY_INSERT [dbo].[Conduct] OFF
GO
SET IDENTITY_INSERT [dbo].[ContactInfo] ON 

INSERT [dbo].[ContactInfo] ([Id], [Name], [Phone], [Address], [SubjectToId], [BHYT], [StudentId]) VALUES (1, N'Dũng', 999, N'hy', 1, 1111, 1)
INSERT [dbo].[ContactInfo] ([Id], [Name], [Phone], [Address], [SubjectToId], [BHYT], [StudentId]) VALUES (2, N'Dũng', 1111, N'hy', 1, 2222, 2)
INSERT [dbo].[ContactInfo] ([Id], [Name], [Phone], [Address], [SubjectToId], [BHYT], [StudentId]) VALUES (4, N'Dũng', 2222, N'hy', 2, 1233, 3)
INSERT [dbo].[ContactInfo] ([Id], [Name], [Phone], [Address], [SubjectToId], [BHYT], [StudentId]) VALUES (5, N'Ngô Quang Dũng', 2222, N'22222', 1, 2166, 4)
INSERT [dbo].[ContactInfo] ([Id], [Name], [Phone], [Address], [SubjectToId], [BHYT], [StudentId]) VALUES (6, N'Ngô Quang Dũng', 3333, N'kkkk', 1, 333333, 5)
INSERT [dbo].[ContactInfo] ([Id], [Name], [Phone], [Address], [SubjectToId], [BHYT], [StudentId]) VALUES (7, N'Ngô Quang Dũng', 9999, N'kkkk', 1, 960, 6)
INSERT [dbo].[ContactInfo] ([Id], [Name], [Phone], [Address], [SubjectToId], [BHYT], [StudentId]) VALUES (8, N'Nghĩa', 9999, N'kkkk', 1, 9999, 7)
SET IDENTITY_INSERT [dbo].[ContactInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[District] ON 

INSERT [dbo].[District] ([Id], [Name], [ProvinceId]) VALUES (1, N'Thanh Xuân', 1)
INSERT [dbo].[District] ([Id], [Name], [ProvinceId]) VALUES (2, N'Hà Đông', 1)
INSERT [dbo].[District] ([Id], [Name], [ProvinceId]) VALUES (3, N'Từ Liêm', 1)
INSERT [dbo].[District] ([Id], [Name], [ProvinceId]) VALUES (4, N'Ba Đình', 1)
INSERT [dbo].[District] ([Id], [Name], [ProvinceId]) VALUES (9, N'Yên Mỹ', 4)
INSERT [dbo].[District] ([Id], [Name], [ProvinceId]) VALUES (10, N'Khoái Châu', 4)
INSERT [dbo].[District] ([Id], [Name], [ProvinceId]) VALUES (11, N'Mỹ Hào', 4)
INSERT [dbo].[District] ([Id], [Name], [ProvinceId]) VALUES (12, N'Văn Giang', 4)
INSERT [dbo].[District] ([Id], [Name], [ProvinceId]) VALUES (13, N'Văn Lâm', 4)
INSERT [dbo].[District] ([Id], [Name], [ProvinceId]) VALUES (14, N'Ân Thi', 4)
SET IDENTITY_INSERT [dbo].[District] OFF
GO
SET IDENTITY_INSERT [dbo].[InfoTHPT] ON 

INSERT [dbo].[InfoTHPT] ([Id], [Province10Id], [Province11Id], [Province12Id], [School10Id], [School11Id], [School12Id], [AbilityId], [ConductId], [Point], [SBD], [HSDDKXT], [Math], [Literature], [English], [Physics], [Chemistry], [Biology], [History], [Geography], [Graduation], [ScoreCard], [StudentId], [Type], [YearGraduation]) VALUES (1, 1, 1, 1, 1, 1, 1, 1, 1, N'10', N'1222', NULL, N'9', N'9', N'9', N'9', N'9', N'9', N'7', N'4', N'/uploads/299c9dae-ace1-42e5-8882-841675d8f573.jpg', N'/uploads/b2a2f4a3-0ffa-4ab5-8350-f2d65d6a2e78.jpg', 1, 1, 2322)
INSERT [dbo].[InfoTHPT] ([Id], [Province10Id], [Province11Id], [Province12Id], [School10Id], [School11Id], [School12Id], [AbilityId], [ConductId], [Point], [SBD], [HSDDKXT], [Math], [Literature], [English], [Physics], [Chemistry], [Biology], [History], [Geography], [Graduation], [ScoreCard], [StudentId], [Type], [YearGraduation]) VALUES (2, 1, 1, 1, 1, 1, 1, 1, 1, N'22', N'2', NULL, N'2', N'4', N'4', N'4', N'4', N'4', N'4', N'4', N'/uploads/b1382278-9cad-49a0-87d6-bd671a5590b6.jpg', N'/uploads/6e0bb982-fdd3-49b3-bb1a-94fa2c422e4e.jpg', 2, 1, 2022)
INSERT [dbo].[InfoTHPT] ([Id], [Province10Id], [Province11Id], [Province12Id], [School10Id], [School11Id], [School12Id], [AbilityId], [ConductId], [Point], [SBD], [HSDDKXT], [Math], [Literature], [English], [Physics], [Chemistry], [Biology], [History], [Geography], [Graduation], [ScoreCard], [StudentId], [Type], [YearGraduation]) VALUES (3, 1, 1, 1, 1, 1, 1, 1, 1, N'8.9', N'1222', N'09999', N'9.8', N'9.8', N'9.8', N'9.8', N'9.8', N'9', N'9', N'4', N'/uploads/a7ec7278-21d7-443a-9dca-4f1093d2d685.jpg', N'/uploads/3937d790-dc4f-4c93-8e86-d2869848ffd8.jpg', 3, 1, 2022)
INSERT [dbo].[InfoTHPT] ([Id], [Province10Id], [Province11Id], [Province12Id], [School10Id], [School11Id], [School12Id], [AbilityId], [ConductId], [Point], [SBD], [HSDDKXT], [Math], [Literature], [English], [Physics], [Chemistry], [Biology], [History], [Geography], [Graduation], [ScoreCard], [StudentId], [Type], [YearGraduation]) VALUES (4, 1, 1, 1, 1, 1, 1, 1, 1, N'10', N'1222', NULL, N'9', N'9', N'9', N'9', N'9', N'9', N'11', N'9', N'/uploads/33213782-0616-4796-af47-5f83a0b6dfa6.jpg', N'/uploads/8214a773-d3c2-46d3-a6f5-a2dc4962c1d8.jpg', 4, 1, 202)
INSERT [dbo].[InfoTHPT] ([Id], [Province10Id], [Province11Id], [Province12Id], [School10Id], [School11Id], [School12Id], [AbilityId], [ConductId], [Point], [SBD], [HSDDKXT], [Math], [Literature], [English], [Physics], [Chemistry], [Biology], [History], [Geography], [Graduation], [ScoreCard], [StudentId], [Type], [YearGraduation]) VALUES (5, 1, 1, 1, 1, 1, 1, 1, 1, N'97', N'93393', NULL, N'98', N'97', N'97', N'97', N'97', N'97', N'97', N'949', NULL, NULL, 5, 1, 2011)
INSERT [dbo].[InfoTHPT] ([Id], [Province10Id], [Province11Id], [Province12Id], [School10Id], [School11Id], [School12Id], [AbilityId], [ConductId], [Point], [SBD], [HSDDKXT], [Math], [Literature], [English], [Physics], [Chemistry], [Biology], [History], [Geography], [Graduation], [ScoreCard], [StudentId], [Type], [YearGraduation]) VALUES (6, 1, 1, 1, 1, 1, 1, 1, 1, N'9999', N'999', NULL, N'9,8', N'9,8', N'9,8', N'9,8', N'9,8', N'9', N'9', N'9', N'/uploads/167134e3-2125-4661-bf0f-3e24c0fcb6ef.jpg', N'/uploads/a749fb04-0ede-4ee9-9f11-9a56d26eace3.jpg', 6, 1, 9000)
INSERT [dbo].[InfoTHPT] ([Id], [Province10Id], [Province11Id], [Province12Id], [School10Id], [School11Id], [School12Id], [AbilityId], [ConductId], [Point], [SBD], [HSDDKXT], [Math], [Literature], [English], [Physics], [Chemistry], [Biology], [History], [Geography], [Graduation], [ScoreCard], [StudentId], [Type], [YearGraduation]) VALUES (7, 1, 1, 1, 1, 1, 1, 1, 1, N'10', N'1222', NULL, N'9,8', N'9,8', N'2', N'6', N'9,8', N'9', N'2', N'18', N'/uploads/6fa6bf01-f03c-4e9d-aafc-fcf5485e66b9.jpg', N'/uploads/a2453b96-841e-478a-a9c1-80657f65ffe9.jpg', 7, 1, 1999)
SET IDENTITY_INSERT [dbo].[InfoTHPT] OFF
GO
SET IDENTITY_INSERT [dbo].[Major] ON 

INSERT [dbo].[Major] ([Id], [Name], [Description], [CreateDate], [EditDate], [Code], [Combination1], [Combination2], [Combination3], [Combination4]) VALUES (1, N'Công nghệ thông tin', N'ko', CAST(N'2022-03-13T00:27:38.783' AS DateTime), NULL, N'7480201', 4, 5, 6, 7)
INSERT [dbo].[Major] ([Id], [Name], [Description], [CreateDate], [EditDate], [Code], [Combination1], [Combination2], [Combination3], [Combination4]) VALUES (2, N'Công nghệ kỹ thuật ô tô', N'ko', CAST(N'2022-03-11T14:53:45.357' AS DateTime), NULL, N'7510205', 4, 5, 6, 7)
INSERT [dbo].[Major] ([Id], [Name], [Description], [CreateDate], [EditDate], [Code], [Combination1], [Combination2], [Combination3], [Combination4]) VALUES (3, N'Công nghệ may', N'ko', CAST(N'2022-05-26T21:21:55.673' AS DateTime), CAST(N'2022-05-26T21:22:26.737' AS DateTime), N'cong-nghe-may', 4, 8, 10, 9)
SET IDENTITY_INSERT [dbo].[Major] OFF
GO
SET IDENTITY_INSERT [dbo].[Nation] ON 

INSERT [dbo].[Nation] ([Id], [Name]) VALUES (1, N'Kinh')
INSERT [dbo].[Nation] ([Id], [Name]) VALUES (2, N'Thái')
INSERT [dbo].[Nation] ([Id], [Name]) VALUES (3, N'Mường')
INSERT [dbo].[Nation] ([Id], [Name]) VALUES (4, N'Khơ me')
SET IDENTITY_INSERT [dbo].[Nation] OFF
GO
SET IDENTITY_INSERT [dbo].[News] ON 

INSERT [dbo].[News] ([Id], [Name], [CategoryId], [Image], [Description], [Detail], [IsNew], [CreateDate], [EditDate], [Url], [DisplayOrder], [Status]) VALUES (1, N'TRƯỜNG ĐẠI HỌC SPKT HƯNG YÊN TỔ CHỨC NGHIỆM THU CÁC ĐỀ TÀI NGHIÊN CỨU KHOA HỌC CỦA SINH VIÊN NĂM HỌC 2021 – 2022', 2, N'/uploads/6d31244a-e96e-484d-a934-03de222b82c2.jpg', N'  Trong tháng 04/2022, trường Đại học SPKT Hưng Yên đã tiến hành nghiệm thu các đề tài nghiên cứu khoa học của sinh viên năm học 2021 – 2022.', N'<p style="margin-right: 0px; margin-bottom: 10px; margin-left: 0px; font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; text-align: justify; background-color: rgb(245, 245, 245);"><span style="background-color: white;"><span style="font-size: 13pt;"><span style="color: rgb(5, 5, 5);">Trong tháng 04/2022, trường Đại học SPKT Hưng Yên đã tiến hành nghiệm thu các đề tài nghiên cứu khoa học của sinh viên năm học 2021 – 2022.</span></span></span></p><p style="margin-right: 0px; margin-bottom: 10px; margin-left: 0px; font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; text-align: justify; background-color: rgb(245, 245, 245);"><span style="background-color: white;"><span style="font-size: 13pt;"><span style="color: rgb(5, 5, 5);">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Năm nay toàn trường có 118 đề tài nghiên cứu khoa học của các sinh viên/nhóm sinh viên đến từ tất cả các khoa chuyên môn trong toàn trường.</span></span></span></p><p style="margin-right: 0px; margin-bottom: 10px; margin-left: 0px; font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; text-align: justify; background-color: rgb(245, 245, 245);"><span style="background-color: white;"><span style="font-size: 13pt;"><span style="color: rgb(5, 5, 5);">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Mặc dù gặp nhiều khó khăn trong bối cảnh dịch bệnh Covid-19 diễn biến phức tạp, việc học tập và nghiên cứu khoa học đều bị ảnh hưởng đáng kể. Tuy nhiên, các inh viên của nhà trường đã nỗ lực vượt khó và đạt được những kết quả tích cực.</span></span></span></p><p style="margin-right: 0px; margin-bottom: 10px; margin-left: 0px; font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; text-align: justify; background-color: rgb(245, 245, 245);"><span style="background-color: white;"><span style="font-size: 13pt;"><span style="color: rgb(5, 5, 5);">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Các báo cáo khoa học của các đề tài đều được thực hiện đúng tiến độ, có cấu trúc hợp lý, bám sát kế hoạch, tuân thủ các quy trình, quy định trong công tác nghiên cứu khoa học của nhà trường.</span></span></span></p><p style="margin-right: 0px; margin-bottom: 10px; margin-left: 0px; font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; text-align: justify; background-color: rgb(245, 245, 245);"><span style="background-color: white;"><span style="font-size: 13pt;"><span style="color: rgb(5, 5, 5);">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Chất lượng các sản phẩm từ các đề tài đều đáp ứng yêu cầu theo quy định, nhiều sản phẩm có giá trị khoa học cao và có thể áp dụng hiệu quả trong thực tiễn.</span></span></span></p><p style="margin-right: 0px; margin-bottom: 10px; margin-left: 0px; font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; text-align: justify; background-color: rgb(245, 245, 245);"><span style="background-color: white;"><span style="font-size: 13pt;"><span style="color: rgb(5, 5, 5);">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hy vọng rằng các mô hình, sản phẩm này sẽ sớm được ứng dụng vào thực tiễn và góp phần khơi dậy tinh thần nghiên cứu khoa học, đổi mới sáng tạo trong các đoàn viên, thanh niên, sinh viên nhà trường.</span></span></span></p><p style="margin-right: 0px; margin-bottom: 10px; margin-left: 0px; font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; text-align: justify; background-color: rgb(245, 245, 245);"><span style="background-color: white;"><span style="font-size: 13pt;"><span style="color: rgb(5, 5, 5);">&nbsp; &nbsp; &nbsp;</span></span></span></p><p style="margin-right: 0px; margin-bottom: 10px; margin-left: 0px; font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; background-color: rgb(245, 245, 245); text-align: center;"><span style="background-color: white;"><span style="font-size: 13pt;"><span style="color: rgb(5, 5, 5);"><em></em></span></span></span></p>', 1, CAST(N'2022-03-11T14:53:45.357' AS DateTime), CAST(N'2022-05-25T22:08:35.447' AS DateTime), N'truong-dai-hoc-spkt-hung-yen-to-chuc-nghiem-thu-cac-de-tai-nghien-cuu-khoa-hoc-cua-sinh-vien-nam-hoc-2021-–-2022', 1, 1)
SET IDENTITY_INSERT [dbo].[News] OFF
GO
SET IDENTITY_INSERT [dbo].[Province] ON 

INSERT [dbo].[Province] ([Id], [Name], [Code]) VALUES (1, N'Hà Nội', N'1')
INSERT [dbo].[Province] ([Id], [Name], [Code]) VALUES (2, N'Hồ Chí Minh', N'2')
INSERT [dbo].[Province] ([Id], [Name], [Code]) VALUES (4, N'Hưng Yên', N'3')
INSERT [dbo].[Province] ([Id], [Name], [Code]) VALUES (5, N'Hải Dương', N'4')
INSERT [dbo].[Province] ([Id], [Name], [Code]) VALUES (6, N'Hà Nam', N'5')
INSERT [dbo].[Province] ([Id], [Name], [Code]) VALUES (7, N'Hải Phòng', N'6')
SET IDENTITY_INSERT [dbo].[Province] OFF
GO
SET IDENTITY_INSERT [dbo].[Question] ON 

INSERT [dbo].[Question] ([Id], [Name], [CategoryId], [Image], [Description], [Detail], [IsNew], [CreateDate], [EditDate], [Url], [DisplayOrder], [Status]) VALUES (1, N'Lập trình Front-end cơ bản 5', 2, N'/uploads/33b88ea6-9c91-48d1-b7a3-6e2b59364bb3.png', N'ko', N'<p>ko</p>', 1, CAST(N'2022-03-11T16:07:44.693' AS DateTime), CAST(N'2022-05-11T00:39:25.157' AS DateTime), N'lap-trinh-front-end-co-ban-5', 3, 1)
INSERT [dbo].[Question] ([Id], [Name], [CategoryId], [Image], [Description], [Detail], [IsNew], [CreateDate], [EditDate], [Url], [DisplayOrder], [Status]) VALUES (2, N'kkk', NULL, N'/uploads/74e8f438-f5fc-47b1-942d-5f0f7eb5542d.jpg', N'kkk', N'<p>bbb</p>', 1, CAST(N'2022-05-11T00:39:43.987' AS DateTime), NULL, N'kkk', 88, 1)
SET IDENTITY_INSERT [dbo].[Question] OFF
GO
SET IDENTITY_INSERT [dbo].[School] ON 

INSERT [dbo].[School] ([Id], [Name], [ProvinceId], [Code]) VALUES (1, N'THPT Ba Vì', 1, 10101)
INSERT [dbo].[School] ([Id], [Name], [ProvinceId], [Code]) VALUES (2, N'THPT Bắc Lương Sơn', 1, 10102)
INSERT [dbo].[School] ([Id], [Name], [ProvinceId], [Code]) VALUES (3, N'THPT Chuyên Hưng Yên', 4, 22011)
INSERT [dbo].[School] ([Id], [Name], [ProvinceId], [Code]) VALUES (4, N'THPT Yên Mỹ', 4, 22012)
SET IDENTITY_INSERT [dbo].[School] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Id], [Name], [Phone], [Email], [Address], [DOB], [Avatar], [Gender], [Status], [CreateDate], [EditDate], [NationId], [CMND], [ProvinceId]) VALUES (1, N'Ngô Quang Dũng', N'5555555', N'aahhah@gmal.com', N'54 - 56 Lê Thanh Nghị, Bách Khoa, Q. Hai Bà Trưng, Hà Nội', CAST(N'2022-05-14T00:43:00.000' AS DateTime), NULL, 1, NULL, CAST(N'2022-05-25T00:45:35.627' AS DateTime), NULL, 1, 999, 1)
INSERT [dbo].[Student] ([Id], [Name], [Phone], [Email], [Address], [DOB], [Avatar], [Gender], [Status], [CreateDate], [EditDate], [NationId], [CMND], [ProvinceId]) VALUES (2, N'Ngô Quang Dũng', N'0977777766', N'admin@gmail.com', N'54 - 56 Lê Thanh Nghị, Bách Khoa, Q. Hai Bà Trưng, Hà Nội', NULL, NULL, 1, NULL, CAST(N'2022-05-25T00:48:52.300' AS DateTime), NULL, 1, 999, 1)
INSERT [dbo].[Student] ([Id], [Name], [Phone], [Email], [Address], [DOB], [Avatar], [Gender], [Status], [CreateDate], [EditDate], [NationId], [CMND], [ProvinceId]) VALUES (3, N'Ngô Quang Dũng2', N'5555555', N'admin@gmail.com', N'54 - 56 Lê Thanh Nghị, Bách Khoa, Q. Hai Bà Trưng, Hà Nội', CAST(N'2022-05-13T22:49:00.000' AS DateTime), NULL, 1, 1, CAST(N'2022-05-26T22:51:03.167' AS DateTime), NULL, 1, 999, 1)
INSERT [dbo].[Student] ([Id], [Name], [Phone], [Email], [Address], [DOB], [Avatar], [Gender], [Status], [CreateDate], [EditDate], [NationId], [CMND], [ProvinceId]) VALUES (4, N'Danh mục 1', N'0977777766', N'aahhah@gmal.com', N'KYOTO', CAST(N'2022-05-08T09:59:00.000' AS DateTime), NULL, 1, 1, CAST(N'2022-05-28T10:01:27.400' AS DateTime), NULL, 1, 999, 1)
INSERT [dbo].[Student] ([Id], [Name], [Phone], [Email], [Address], [DOB], [Avatar], [Gender], [Status], [CreateDate], [EditDate], [NationId], [CMND], [ProvinceId]) VALUES (5, N'333333eeeeee', N'0977777766', N'admin@gmail.com', N'hưng yên', CAST(N'2022-05-15T11:04:00.000' AS DateTime), NULL, 1, 0, CAST(N'2022-05-28T11:04:35.283' AS DateTime), NULL, 1, 999, 1)
INSERT [dbo].[Student] ([Id], [Name], [Phone], [Email], [Address], [DOB], [Avatar], [Gender], [Status], [CreateDate], [EditDate], [NationId], [CMND], [ProvinceId]) VALUES (6, N'Danh mục 1', N'0977777766', N'nghiadv1006@gmail.com', N'54 - 56 Lê Thanh Nghị, Bách Khoa, Q. Hai Bà Trưng, Hà Nội', CAST(N'2022-05-15T13:32:00.000' AS DateTime), NULL, 1, 0, CAST(N'2022-05-29T13:34:22.163' AS DateTime), NULL, 1, 9999, 1)
INSERT [dbo].[Student] ([Id], [Name], [Phone], [Email], [Address], [DOB], [Avatar], [Gender], [Status], [CreateDate], [EditDate], [NationId], [CMND], [ProvinceId]) VALUES (7, N'Nghĩa', N'5555555', N'nghiadv1006@gmail.com', N'hưng yên', CAST(N'2022-05-07T13:37:00.000' AS DateTime), NULL, 1, 0, CAST(N'2022-05-29T13:38:38.203' AS DateTime), NULL, 1, 99999, 1)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[SubjectTo] ON 

INSERT [dbo].[SubjectTo] ([Id], [Name]) VALUES (1, N'Không')
INSERT [dbo].[SubjectTo] ([Id], [Name]) VALUES (2, N'01')
INSERT [dbo].[SubjectTo] ([Id], [Name]) VALUES (3, N'02')
INSERT [dbo].[SubjectTo] ([Id], [Name]) VALUES (4, N'03')
INSERT [dbo].[SubjectTo] ([Id], [Name]) VALUES (5, N'04')
INSERT [dbo].[SubjectTo] ([Id], [Name]) VALUES (6, N'05')
INSERT [dbo].[SubjectTo] ([Id], [Name]) VALUES (7, N'06')
INSERT [dbo].[SubjectTo] ([Id], [Name]) VALUES (8, N'07')
SET IDENTITY_INSERT [dbo].[SubjectTo] OFF
GO
SET IDENTITY_INSERT [dbo].[Ward] ON 

INSERT [dbo].[Ward] ([Id], [Name], [DistrictId]) VALUES (1, N'Phường Thanh Xuân Bắc', 1)
INSERT [dbo].[Ward] ([Id], [Name], [DistrictId]) VALUES (2, N'Phường Thanh Xuân Nam', 1)
INSERT [dbo].[Ward] ([Id], [Name], [DistrictId]) VALUES (3, N'Tố Hữu', 2)
INSERT [dbo].[Ward] ([Id], [Name], [DistrictId]) VALUES (4, N'Tân Lập', 9)
INSERT [dbo].[Ward] ([Id], [Name], [DistrictId]) VALUES (5, N'Trung Hưng', 9)
INSERT [dbo].[Ward] ([Id], [Name], [DistrictId]) VALUES (6, N'Liêu Xá', 9)
INSERT [dbo].[Ward] ([Id], [Name], [DistrictId]) VALUES (7, N'Trung Hòa', 9)
SET IDENTITY_INSERT [dbo].[Ward] OFF
GO
SET IDENTITY_INSERT [dbo].[Wish] ON 

INSERT [dbo].[Wish] ([Id], [Major1Id], [Major2Id], [Combination1Id], [Combination2Id], [Point1], [Point2], [StudentId]) VALUES (1, 1, 1, 4, 4, N'11', N'11', 1)
INSERT [dbo].[Wish] ([Id], [Major1Id], [Major2Id], [Combination1Id], [Combination2Id], [Point1], [Point2], [StudentId]) VALUES (2, 1, 1, 4, 4, N'3', N'3', 2)
INSERT [dbo].[Wish] ([Id], [Major1Id], [Major2Id], [Combination1Id], [Combination2Id], [Point1], [Point2], [StudentId]) VALUES (3, 1, 1, 4, 4, N'8', N'8', 3)
INSERT [dbo].[Wish] ([Id], [Major1Id], [Major2Id], [Combination1Id], [Combination2Id], [Point1], [Point2], [StudentId]) VALUES (4, 1, 1, 4, 4, N'11', N'11', 4)
INSERT [dbo].[Wish] ([Id], [Major1Id], [Major2Id], [Combination1Id], [Combination2Id], [Point1], [Point2], [StudentId]) VALUES (5, 1, 1, 4, 4, N'97', N'97', 5)
INSERT [dbo].[Wish] ([Id], [Major1Id], [Major2Id], [Combination1Id], [Combination2Id], [Point1], [Point2], [StudentId]) VALUES (6, 1, 1, 4, 4, N'9', N'9', 6)
INSERT [dbo].[Wish] ([Id], [Major1Id], [Major2Id], [Combination1Id], [Combination2Id], [Point1], [Point2], [StudentId]) VALUES (7, 1, 1, 4, 4, N'11', N'11', 7)
SET IDENTITY_INSERT [dbo].[Wish] OFF
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ContactInfo]  WITH CHECK ADD  CONSTRAINT [FK_ContactInfo_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[ContactInfo] CHECK CONSTRAINT [FK_ContactInfo_Student]
GO
ALTER TABLE [dbo].[ContactInfo]  WITH CHECK ADD  CONSTRAINT [FK_ContactInfo_SubjectTo] FOREIGN KEY([SubjectToId])
REFERENCES [dbo].[SubjectTo] ([Id])
GO
ALTER TABLE [dbo].[ContactInfo] CHECK CONSTRAINT [FK_ContactInfo_SubjectTo]
GO
ALTER TABLE [dbo].[District]  WITH CHECK ADD  CONSTRAINT [FK_District_Province] FOREIGN KEY([ProvinceId])
REFERENCES [dbo].[Province] ([Id])
GO
ALTER TABLE [dbo].[District] CHECK CONSTRAINT [FK_District_Province]
GO
ALTER TABLE [dbo].[InfoTHPT]  WITH CHECK ADD  CONSTRAINT [FK_InfoTHPT_Ability] FOREIGN KEY([AbilityId])
REFERENCES [dbo].[Ability] ([Id])
GO
ALTER TABLE [dbo].[InfoTHPT] CHECK CONSTRAINT [FK_InfoTHPT_Ability]
GO
ALTER TABLE [dbo].[InfoTHPT]  WITH CHECK ADD  CONSTRAINT [FK_InfoTHPT_Conduct] FOREIGN KEY([ConductId])
REFERENCES [dbo].[Conduct] ([Id])
GO
ALTER TABLE [dbo].[InfoTHPT] CHECK CONSTRAINT [FK_InfoTHPT_Conduct]
GO
ALTER TABLE [dbo].[InfoTHPT]  WITH CHECK ADD  CONSTRAINT [FK_InfoTHPT_Province] FOREIGN KEY([Province10Id])
REFERENCES [dbo].[Province] ([Id])
GO
ALTER TABLE [dbo].[InfoTHPT] CHECK CONSTRAINT [FK_InfoTHPT_Province]
GO
ALTER TABLE [dbo].[InfoTHPT]  WITH CHECK ADD  CONSTRAINT [FK_InfoTHPT_School] FOREIGN KEY([School10Id])
REFERENCES [dbo].[School] ([Id])
GO
ALTER TABLE [dbo].[InfoTHPT] CHECK CONSTRAINT [FK_InfoTHPT_School]
GO
ALTER TABLE [dbo].[InfoTHPT]  WITH CHECK ADD  CONSTRAINT [FK_InfoTHPT_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[InfoTHPT] CHECK CONSTRAINT [FK_InfoTHPT_Student]
GO
ALTER TABLE [dbo].[News]  WITH CHECK ADD  CONSTRAINT [FK_News_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[News] CHECK CONSTRAINT [FK_News_Category]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Nation] FOREIGN KEY([NationId])
REFERENCES [dbo].[Nation] ([Id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Nation]
GO
ALTER TABLE [dbo].[Ward]  WITH CHECK ADD  CONSTRAINT [FK_Ward_District] FOREIGN KEY([DistrictId])
REFERENCES [dbo].[District] ([Id])
GO
ALTER TABLE [dbo].[Ward] CHECK CONSTRAINT [FK_Ward_District]
GO
ALTER TABLE [dbo].[Wish]  WITH CHECK ADD  CONSTRAINT [FK_Wish_Combination] FOREIGN KEY([Combination1Id])
REFERENCES [dbo].[Combination] ([Id])
GO
ALTER TABLE [dbo].[Wish] CHECK CONSTRAINT [FK_Wish_Combination]
GO
ALTER TABLE [dbo].[Wish]  WITH CHECK ADD  CONSTRAINT [FK_Wish_Major] FOREIGN KEY([Major1Id])
REFERENCES [dbo].[Major] ([Id])
GO
ALTER TABLE [dbo].[Wish] CHECK CONSTRAINT [FK_Wish_Major]
GO
ALTER TABLE [dbo].[Wish]  WITH CHECK ADD  CONSTRAINT [FK_Wish_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[Wish] CHECK CONSTRAINT [FK_Wish_Student]
GO
