USE [TestDb]
GO

/****** Object:  Table [dbo].[Admin]    Script Date: 2023-11-25 10:25:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Admin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL
) ON [PRIMARY]
GO




USE [TestDb]
GO

/****** Object:  Table [dbo].[Category]    Script Date: 2023-11-25 10:25:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[IsActive] [bit] NULL
) ON [PRIMARY]
GO





USE [TestDb]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 2023-11-25 10:25:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[CategoryId] [int] NULL,
	[Desc] [nvarchar](50) NULL,
	[Price] [float] NULL,
	[Imagelg] [nvarchar](100) NULL,
	[ImageSm] [nvarchar](100) NULL,
	[AgeGroup] [nvarchar](20) NULL,
	[IsActive] [bit] NULL
) ON [PRIMARY]
GO




>>>>>>

USE [TestDb]
GO

/****** Object:  StoredProcedure [dbo].[AddProduct]    Script Date: 2023-11-15 10:14:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetProducts] 
as

Select * from  Product 

GO

-->>>>>>>>>>>>>>>>>>

USE [TestDb]
GO

/****** Object:  StoredProcedure [dbo].[EditProduct]    Script Date: 2023-11-15 10:21:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EditProduct]
@Id int,
@Name nvarchar(50),  
@CategoryId int,
@Desc nvarchar(50), 
@Price float,
@Imagelg nvarchar(100), 
@ImageSm nvarchar(100), 
@AgeGroup nvarchar(20), 
@IsActive bit
AS
Update Product set Name = @Name, CategoryId = @CategoryId, [Desc]=@Desc,Price=@Price, Imagelg =@Imagelg,ImageSm=@ImageSm,AgeGroup=@AgeGroup,IsActive=@IsActive   
where Id = @Id
GO

-->>>>>>>>>>>>>>>>>>

USE [TestDb]
GO

/****** Object:  StoredProcedure [dbo].[EditCategory]    Script Date: 2023-11-15 10:21:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[EditCategory]
@Id int,
@Name nvarchar(50),
@IsActive bit
AS
Update Category set [Name] = @Name, IsActive = @IsActive where Id = @Id
GO

-->>>>>>>>>>>>>>>>>>
USE [TestDb]
GO

/****** Object:  StoredProcedure [dbo].[EditAdmin]    Script Date: 2023-11-15 10:21:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EditAdmin] 
@Username nvarchar(50), 
@Password nvarchar(50)
AS
Update Admin set Username = @Username, Password = @Password where Username = @Username
GO

-->>>>>>>>>>>>>>>>>>

USE [TestDb]
GO

/****** Object:  StoredProcedure [dbo].[AddProduct]    Script Date: 2023-11-15 10:21:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddProduct] 
@Name nvarchar(50),  
@CategoryId int,
@Desc nvarchar(50), 
@Price float,
@Imagelg nvarchar(100), 
@ImageSm nvarchar(100), 
@AgeGroup nvarchar(20), 
@IsActive bit
AS
INSERT INTO Product values (@Name, @CategoryId, @Desc, @Price, @Imagelg, @ImageSm, @AgeGroup, @IsActive);
GO

-->>>>>>>>>>>>>>>>>>

USE [TestDb]
GO

/****** Object:  StoredProcedure [dbo].[AddCategory]    Script Date: 2023-11-15 10:21:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddCategory]
@Id int,
@Name nvarchar(50),
@IsActive bit
AS
INSERT INTO Category(Name, IsActive) VALUES (@Name, @IsActive);
GO
-->>>>>>>>>>>>>>>>>>

USE [TestDb]
GO

/****** Object:  StoredProcedure [dbo].[AddAdmin]    Script Date: 2023-11-15 10:21:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddAdmin] 
@Username nvarchar(50), 
@Password nvarchar(50)
AS
INSERT INTO Admin(Username, Password) VALUES (@Username, @Password);

GO
-->>>>>>>>>>>>>>>>>>









