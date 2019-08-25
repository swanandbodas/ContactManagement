USE [CM]
GO

/****** Object:  Table [dbo].[Contact]    Script Date: 26-08-2019 02:36:43 ******/
DROP TABLE [dbo].[Contact]
GO

/****** Object:  Table [dbo].[Contact]    Script Date: 26-08-2019 02:36:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Contact](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[ContactNumber] [varchar](20) NULL,
	[Active] [bit] DEFAULT 1 NOT NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


