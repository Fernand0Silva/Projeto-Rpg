IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
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

CREATE TABLE [TB_PERSONAGENS] (
    [Id] int NOT NULL IDENTITY,
    [Nome] Varchar(200) NOT NULL,
    [PontosVida] int NOT NULL,
    [Forca] int NOT NULL,
    [Defesa] int NOT NULL,
    [Inteligencia] int NOT NULL,
    [Classe] int NOT NULL,
    CONSTRAINT [PK_TB_PERSONAGENS] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Classe', N'Defesa', N'Forca', N'Inteligencia', N'Nome', N'PontosVida') AND [object_id] = OBJECT_ID(N'[TB_PERSONAGENS]'))
    SET IDENTITY_INSERT [TB_PERSONAGENS] ON;
INSERT INTO [TB_PERSONAGENS] ([Id], [Classe], [Defesa], [Forca], [Inteligencia], [Nome], [PontosVida])
VALUES (1, 1, 23, 17, 33, 'Frodo', 100),
(2, 1, 25, 15, 30, 'Sam', 100),
(3, 3, 21, 18, 35, 'Galadriel', 100),
(4, 2, 18, 18, 37, 'Gandalf', 100),
(5, 1, 17, 20, 31, 'Hobbit', 100),
(6, 3, 13, 21, 34, 'Celeborn', 100),
(7, 2, 11, 25, 35, 'Radagast', 100);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Classe', N'Defesa', N'Forca', N'Inteligencia', N'Nome', N'PontosVida') AND [object_id] = OBJECT_ID(N'[TB_PERSONAGENS]'))
    SET IDENTITY_INSERT [TB_PERSONAGENS] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240402125600_InitialCreate', N'8.0.3');
GO

COMMIT;
GO

