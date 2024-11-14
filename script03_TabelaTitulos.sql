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

CREATE TABLE [TB_PARTIDAS] (
    [Id] int NOT NULL IDENTITY,
    [Dia] varchar(200) NOT NULL,
    [Horario] varchar(200) NOT NULL,
    [Estadio] varchar(200) NOT NULL,
    [Competicao] varchar(200) NOT NULL,
    [Adversario] varchar(200) NOT NULL,
    [Resultado] varchar(200) NOT NULL,
    [Placar] varchar(200) NOT NULL,
    CONSTRAINT [PK_TB_PARTIDAS] PRIMARY KEY ([Id])
);

CREATE TABLE [TB_TITULOS] (
    [Id] int NOT NULL IDENTITY,
    [Data] varchar(200) NOT NULL,
    [Premiacao] int NOT NULL,
    [Campeonato] varchar(200) NOT NULL,
    [Artilheiro] varchar(200) NOT NULL,
    CONSTRAINT [PK_TB_TITULOS] PRIMARY KEY ([Id])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Adversario', N'Competicao', N'Dia', N'Estadio', N'Horario', N'Placar', N'Resultado') AND [object_id] = OBJECT_ID(N'[TB_PARTIDAS]'))
    SET IDENTITY_INSERT [TB_PARTIDAS] ON;
INSERT INTO [TB_PARTIDAS] ([Id], [Adversario], [Competicao], [Dia], [Estadio], [Horario], [Placar], [Resultado])
VALUES (1, 'Flamengo', 'Brasileirao Serie A', '16/12/2015', 'Maracana', '21:30', '3x0', 'Vitoria'),
(2, 'Racing', 'Sulamericana', '23/10/2024', 'Neo Quimica Arena', '21:00', '2x2', 'Empate'),
(3, 'Palmeiras', 'Copa do Brasil', '01/12/2024', 'Allianz Parque', '19:00', '51x0', 'Vitoria');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Adversario', N'Competicao', N'Dia', N'Estadio', N'Horario', N'Placar', N'Resultado') AND [object_id] = OBJECT_ID(N'[TB_PARTIDAS]'))
    SET IDENTITY_INSERT [TB_PARTIDAS] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Artilheiro', N'Campeonato', N'Data', N'Premiacao') AND [object_id] = OBJECT_ID(N'[TB_TITULOS]'))
    SET IDENTITY_INSERT [TB_TITULOS] ON;
INSERT INTO [TB_TITULOS] ([Id], [Artilheiro], [Campeonato], [Data], [Premiacao])
VALUES (1, 'Paolo Guerrero', 'Mundial de Clubes', '16/12/2012', 1000000),
(2, 'Emerson Sheik', 'Libertadores da America', '04/06/2012', 2000000),
(3, 'Jo', 'Brasileirao Serie A', '15/11/2017', 1000000);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Artilheiro', N'Campeonato', N'Data', N'Premiacao') AND [object_id] = OBJECT_ID(N'[TB_TITULOS]'))
    SET IDENTITY_INSERT [TB_TITULOS] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241114010044_Titulos', N'9.0.0');

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241114010107_Partidas', N'9.0.0');

COMMIT;
GO

