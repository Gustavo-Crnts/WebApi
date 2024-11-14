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
CREATE TABLE [TB_JOGADORES] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NOT NULL,
    [Salario] int NOT NULL,
    [Partidas] int NOT NULL,
    [Gols] int NOT NULL,
    [Assistencias] int NOT NULL,
    [Posicao] int NOT NULL,
    CONSTRAINT [PK_TB_JOGADORES] PRIMARY KEY ([Id])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Assistencias', N'Gols', N'Nome', N'Partidas', N'Posicao', N'Salario') AND [object_id] = OBJECT_ID(N'[TB_JOGADORES]'))
    SET IDENTITY_INSERT [TB_JOGADORES] ON;
INSERT INTO [TB_JOGADORES] ([Id], [Assistencias], [Gols], [Nome], [Partidas], [Posicao], [Salario])
VALUES (1, 13, 10, 'Rodrigo Garro', 50, 3, 700000),
(2, 1, 1, 'Andre Ramalho', 35, 2, 500000),
(3, 0, 0, 'Hugo Souza', 28, 1, 350000),
(4, 8, 26, 'Yuri Alberto', 60, 4, 1500000),
(5, 4, 3, 'Memphis Depay', 10, 4, 3000000);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Assistencias', N'Gols', N'Nome', N'Partidas', N'Posicao', N'Salario') AND [object_id] = OBJECT_ID(N'[TB_JOGADORES]'))
    SET IDENTITY_INSERT [TB_JOGADORES] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241114002127_IntialCreate', N'9.0.0');

COMMIT;
GO

