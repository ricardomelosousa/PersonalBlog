
--Instruções para popular o banco de dados abaixo segue dois tipos de exemplos ---------
--Usando migration os seguites comando devem ser executados no PMC com o projeto PersonalBlog setado com default e no PMC como 
--Default Project selecione PersonalBlog.Infra e rode sequencialmente os seguintes:

--Add-Migration InitialCreate
--Update-Database


---Caso não opte por codefirst segue abaixo querys a serem executadas



BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [BlogPost] (
    [PostId] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ShortDescription] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_BlogPost] PRIMARY KEY ([PostId])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'PostId', N'ShortDescription', N'Title') AND [object_id] = OBJECT_ID(N'[BlogPost]'))
    SET IDENTITY_INSERT [BlogPost] ON;
INSERT INTO [BlogPost] ([PostId], [ShortDescription], [Title])
VALUES (1, N'How to use fetch to get a list of blog posts', N'How to capture posts via APIs'),
(2, N'How to save a list of posts using IndexedDB', N'Using Indexed DB'),
(3, N'How to use the Cache API to store blog posts that can be available offline', N'Using Cache to store Blog posts'),
(4, N'How to use Service Workers to get data from cache when user is offline', N'Obtaining cache data from Service Worker'),
(5, N'How to create the files that allow you to install your site as an App on your phone', N'Creating a Installable Web App'),
(6, N'How to send push notifications to call your user attention to something on your app', N'Sending push notifications'),
(7, N'How powerful the native file inputs can be', N'Camera, Microphone and Video'),
(8, N'How to know where your user is located using geocoding', N'Geolocation'),
(9, N'How to vibrate your phone', N'Vibration'),
(10, N'How to capture phone gyroscope', N'Gyroscope'),
(11, N'How to improve the implementation', N'Code Improvements'),
(12, N'How connect to a Phone and debug from there', N'Debugging on the Phone'),
(13, N'Using AutoMapper', N'Using AutoMapper'),
(14, N'Using AutoMapper part 2', N'Using AutoMapper part 2');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'PostId', N'ShortDescription', N'Title') AND [object_id] = OBJECT_ID(N'[BlogPost]'))
    SET IDENTITY_INSERT [BlogPost] OFF;
GO


GO

COMMIT;
GO

