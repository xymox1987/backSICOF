use DataBaseSICOF
GO
IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [taskEntities] (
    [Id] int NOT NULL IDENTITY,
    [Estado] int NOT NULL,
    [fechaCreacion] datetime2 NOT NULL,
    [UsuarioCrea] nvarchar(max) NULL,
    [fechaEdicion] datetime2 NOT NULL,
    [usuarioModifica] nvarchar(max) NULL,
    [Name] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_taskEntities] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Version] (
    [Id] uniqueidentifier NOT NULL,
    [Estado] int NOT NULL,
    [fechaCreacion] datetime2 NOT NULL,
    [UsuarioCrea] nvarchar(max) NULL,
    [fechaEdicion] datetime2 NOT NULL,
    [usuarioModifica] nvarchar(max) NULL,
    [Nombre_Plataforma] nvarchar(255) NULL,
    [Fecha_Publicacion] datetime2 NOT NULL,
    [Numero_Version] nvarchar(20) NULL,
    [Ambiente] nvarchar(20) NULL,
    [Rama_Origen] nvarchar(20) NULL,
    [Descripcion] nvarchar(1500) NULL,
    CONSTRAINT [PK_Version] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200710181539_MigracionInicial', N'3.1.5');

GO



INSERT INTO VERSION VALUES(newid(),1,GETDATE(),'John',GETDATE(),'','BackSICOF',GETDATE(),'1.0.0','DESARROLLO','MASTER','PRUEBA DE VERSION')
INSERT INTO VERSION VALUES(newid(),1,GETDATE(),'John',GETDATE(),'','BackSICOF',GETDATE(),'1.0.1','DESARROLLO','MASTER','PRUEBA DE VERSION')

SELECT * FROM Version



