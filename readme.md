# ѕриложение дл€ работы с авторизацией и капчей.
** ¬ программе используетс€ база данных дл€ хранени€ пользователей у которых есть логин и пароль дл€ авторизации. **
¬от пример работы:
- ƒобавить пользовател€ в базу
- Ќажать кнопку авторизоватьс€ и ввести логин с паролем указанные на прошом этапе.
- ≈сли пользователь найден, то выйдет окно об успешной авторизации. ≈сли не найден, то нужно будет решить капчу в течение 10 секунд, после чего она обновитс€.
-

„тобы запустить программу нужно:
-”становить (создать) базу данных из скрипта, который расположен в проекте (sql_create_table.sql) или скопировать код ниже:
``` USE master
GO
CREATE DATABASE [DB_Users]
GO 
USE [DB_Users]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 25.06.2023 13:49:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
	[First_Name] [nvarchar](50) NULL,
	[Role_Name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [Login], [Password], [First_Name], [Role_Name]) VALUES (4, N'funny', N'somepass', N'Dave', N'Admin')
INSERT [dbo].[Users] ([ID], [Login], [Password], [First_Name], [Role_Name]) VALUES (6, N'bummer', N'02061995', N'Fred', N'Seller')
INSERT [dbo].[Users] ([ID], [Login], [Password], [First_Name], [Role_Name]) VALUES (8, N'dolorous', N'polk159', N'Brian', N'Seller')
INSERT [dbo].[Users] ([ID], [Login], [Password], [First_Name], [Role_Name]) VALUES (19, N'Boss', N'123456', N'Jorge', N'Director')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO

```
