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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210330205456_InitialCreate')
BEGIN
    CREATE TABLE [Containers] (
        [Id] int NOT NULL IDENTITY,
        [Number] nvarchar(max) NULL,
        [Type] nvarchar(max) NULL,
        [Status] nvarchar(max) NULL,
        [Category] nvarchar(max) NULL,
        CONSTRAINT [PK_Containers] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210330205456_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210330205456_InitialCreate', N'5.0.4');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331012341_TabelaMov')
BEGIN
    CREATE TABLE [Movimentations] (
        [Id] int NOT NULL IDENTITY,
        [Type_Mov] nvarchar(max) NULL,
        [Dt_Init] datetime2 NOT NULL,
        [Dt_Fin] datetime2 NOT NULL,
        CONSTRAINT [PK_Movimentations] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331012341_TabelaMov')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210331012341_TabelaMov', N'5.0.4');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331020153_Fix')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Containers]') AND [c].[name] = N'Type');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Containers] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Containers] ALTER COLUMN [Type] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331020153_Fix')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210331020153_Fix', N'5.0.4');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331022333_Fix1')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movimentations]') AND [c].[name] = N'Type_Mov');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Movimentations] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Movimentations] ALTER COLUMN [Type_Mov] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331022333_Fix1')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Containers]') AND [c].[name] = N'Status');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Containers] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Containers] ALTER COLUMN [Status] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331022333_Fix1')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Containers]') AND [c].[name] = N'Category');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Containers] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Containers] ALTER COLUMN [Category] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331022333_Fix1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210331022333_Fix1', N'5.0.4');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movimentations]') AND [c].[name] = N'Type_Mov');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Movimentations] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Movimentations] DROP COLUMN [Type_Mov];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Containers]') AND [c].[name] = N'Category');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Containers] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Containers] DROP COLUMN [Category];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Containers]') AND [c].[name] = N'Status');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Containers] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Containers] DROP COLUMN [Status];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    EXEC sp_rename N'[Containers].[Type]', N'Client', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    ALTER TABLE [Movimentations] ADD [Type_MovId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    ALTER TABLE [Containers] ADD [CategoryId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    ALTER TABLE [Containers] ADD [StatusId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    ALTER TABLE [Containers] ADD [TypeId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    CREATE TABLE [ContainerCategory] (
        [Id] int NOT NULL IDENTITY,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_ContainerCategory] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    CREATE TABLE [ContainerStatus] (
        [Id] int NOT NULL IDENTITY,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_ContainerStatus] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    CREATE TABLE [ContainerType] (
        [Id] int NOT NULL IDENTITY,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_ContainerType] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    CREATE TABLE [MovType] (
        [Id] int NOT NULL IDENTITY,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_MovType] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    CREATE INDEX [IX_Movimentations_Type_MovId] ON [Movimentations] ([Type_MovId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    CREATE INDEX [IX_Containers_CategoryId] ON [Containers] ([CategoryId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    CREATE INDEX [IX_Containers_StatusId] ON [Containers] ([StatusId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    CREATE INDEX [IX_Containers_TypeId] ON [Containers] ([TypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    ALTER TABLE [Containers] ADD CONSTRAINT [FK_Containers_ContainerCategory_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [ContainerCategory] ([Id]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    ALTER TABLE [Containers] ADD CONSTRAINT [FK_Containers_ContainerStatus_StatusId] FOREIGN KEY ([StatusId]) REFERENCES [ContainerStatus] ([Id]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    ALTER TABLE [Containers] ADD CONSTRAINT [FK_Containers_ContainerType_TypeId] FOREIGN KEY ([TypeId]) REFERENCES [ContainerType] ([Id]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    ALTER TABLE [Movimentations] ADD CONSTRAINT [FK_Movimentations_MovType_Type_MovId] FOREIGN KEY ([Type_MovId]) REFERENCES [MovType] ([Id]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331111649_Fix2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210331111649_Fix2', N'5.0.4');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331112621_fix2.1')
BEGIN
    ALTER TABLE [Containers] DROP CONSTRAINT [FK_Containers_ContainerCategory_CategoryId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331112621_fix2.1')
BEGIN
    ALTER TABLE [Containers] DROP CONSTRAINT [FK_Containers_ContainerStatus_StatusId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331112621_fix2.1')
BEGIN
    ALTER TABLE [Containers] DROP CONSTRAINT [FK_Containers_ContainerType_TypeId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331112621_fix2.1')
BEGIN
    ALTER TABLE [ContainerType] DROP CONSTRAINT [PK_ContainerType];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331112621_fix2.1')
BEGIN
    ALTER TABLE [ContainerStatus] DROP CONSTRAINT [PK_ContainerStatus];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331112621_fix2.1')
BEGIN
    ALTER TABLE [ContainerCategory] DROP CONSTRAINT [PK_ContainerCategory];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331112621_fix2.1')
BEGIN
    EXEC sp_rename N'[ContainerType]', N'ContainerTypes';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331112621_fix2.1')
BEGIN
    EXEC sp_rename N'[ContainerStatus]', N'ContainerStatuses';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331112621_fix2.1')
BEGIN
    EXEC sp_rename N'[ContainerCategory]', N'ContainerCategories';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331112621_fix2.1')
BEGIN
    ALTER TABLE [ContainerTypes] ADD CONSTRAINT [PK_ContainerTypes] PRIMARY KEY ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331112621_fix2.1')
BEGIN
    ALTER TABLE [ContainerStatuses] ADD CONSTRAINT [PK_ContainerStatuses] PRIMARY KEY ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331112621_fix2.1')
BEGIN
    ALTER TABLE [ContainerCategories] ADD CONSTRAINT [PK_ContainerCategories] PRIMARY KEY ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331112621_fix2.1')
BEGIN
    ALTER TABLE [Containers] ADD CONSTRAINT [FK_Containers_ContainerCategories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [ContainerCategories] ([Id]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331112621_fix2.1')
BEGIN
    ALTER TABLE [Containers] ADD CONSTRAINT [FK_Containers_ContainerStatuses_StatusId] FOREIGN KEY ([StatusId]) REFERENCES [ContainerStatuses] ([Id]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331112621_fix2.1')
BEGIN
    ALTER TABLE [Containers] ADD CONSTRAINT [FK_Containers_ContainerTypes_TypeId] FOREIGN KEY ([TypeId]) REFERENCES [ContainerTypes] ([Id]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331112621_fix2.1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210331112621_fix2.1', N'5.0.4');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    ALTER TABLE [Containers] DROP CONSTRAINT [FK_Containers_ContainerCategories_CategoryId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    ALTER TABLE [Containers] DROP CONSTRAINT [FK_Containers_ContainerStatuses_StatusId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    ALTER TABLE [Containers] DROP CONSTRAINT [FK_Containers_ContainerTypes_TypeId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    ALTER TABLE [Movimentations] DROP CONSTRAINT [FK_Movimentations_MovType_Type_MovId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    DROP INDEX [IX_Movimentations_Type_MovId] ON [Movimentations];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    DROP INDEX [IX_Containers_CategoryId] ON [Containers];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    DROP INDEX [IX_Containers_StatusId] ON [Containers];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    DROP INDEX [IX_Containers_TypeId] ON [Containers];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movimentations]') AND [c].[name] = N'Type_MovId');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Movimentations] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [Movimentations] DROP COLUMN [Type_MovId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Containers]') AND [c].[name] = N'CategoryId');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Containers] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [Containers] DROP COLUMN [CategoryId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Containers]') AND [c].[name] = N'StatusId');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Containers] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [Containers] DROP COLUMN [StatusId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    DECLARE @var10 sysname;
    SELECT @var10 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Containers]') AND [c].[name] = N'TypeId');
    IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Containers] DROP CONSTRAINT [' + @var10 + '];');
    ALTER TABLE [Containers] DROP COLUMN [TypeId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    ALTER TABLE [Movimentations] ADD [MovTypeId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    ALTER TABLE [Containers] ADD [ContainerCategoryId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    ALTER TABLE [Containers] ADD [ContainerStatusId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    ALTER TABLE [Containers] ADD [ContainerTypeId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    CREATE INDEX [IX_Movimentations_MovTypeId] ON [Movimentations] ([MovTypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    CREATE INDEX [IX_Containers_ContainerCategoryId] ON [Containers] ([ContainerCategoryId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    CREATE INDEX [IX_Containers_ContainerStatusId] ON [Containers] ([ContainerStatusId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    CREATE INDEX [IX_Containers_ContainerTypeId] ON [Containers] ([ContainerTypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    ALTER TABLE [Containers] ADD CONSTRAINT [FK_Containers_ContainerCategories_ContainerCategoryId] FOREIGN KEY ([ContainerCategoryId]) REFERENCES [ContainerCategories] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    ALTER TABLE [Containers] ADD CONSTRAINT [FK_Containers_ContainerStatuses_ContainerStatusId] FOREIGN KEY ([ContainerStatusId]) REFERENCES [ContainerStatuses] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    ALTER TABLE [Containers] ADD CONSTRAINT [FK_Containers_ContainerTypes_ContainerTypeId] FOREIGN KEY ([ContainerTypeId]) REFERENCES [ContainerTypes] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    ALTER TABLE [Movimentations] ADD CONSTRAINT [FK_Movimentations_MovType_MovTypeId] FOREIGN KEY ([MovTypeId]) REFERENCES [MovType] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331144805_fix11')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210331144805_fix11', N'5.0.4');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331154403_fix3103211243')
BEGIN
    DROP TABLE [Containers];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331154403_fix3103211243')
BEGIN
    DROP TABLE [Movimentations];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331154403_fix3103211243')
BEGIN
    DROP TABLE [ContainerCategories];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331154403_fix3103211243')
BEGIN
    DROP TABLE [ContainerStatuses];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331154403_fix3103211243')
BEGIN
    DROP TABLE [ContainerTypes];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331154403_fix3103211243')
BEGIN
    DROP TABLE [MovType];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331154403_fix3103211243')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210331154403_fix3103211243', N'5.0.4');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331160854_fix3103211308')
BEGIN
    CREATE TABLE [ContainerCategory] (
        [Id] int NOT NULL IDENTITY,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_ContainerCategory] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331160854_fix3103211308')
BEGIN
    CREATE TABLE [ContainerStatus] (
        [Id] int NOT NULL IDENTITY,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_ContainerStatus] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331160854_fix3103211308')
BEGIN
    CREATE TABLE [ContainerTypes] (
        [Id] int NOT NULL IDENTITY,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_ContainerTypes] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331160854_fix3103211308')
BEGIN
    CREATE TABLE [Container] (
        [Id] int NOT NULL IDENTITY,
        [Client] nvarchar(max) NULL,
        [Number] nvarchar(max) NULL,
        [ContainerTypeId] int NOT NULL,
        [ContainerStatusId] int NOT NULL,
        [ContainerCategoryId] int NOT NULL,
        CONSTRAINT [PK_Container] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Container_ContainerCategory_ContainerCategoryId] FOREIGN KEY ([ContainerCategoryId]) REFERENCES [ContainerCategory] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Container_ContainerStatus_ContainerStatusId] FOREIGN KEY ([ContainerStatusId]) REFERENCES [ContainerStatus] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Container_ContainerTypes_ContainerTypeId] FOREIGN KEY ([ContainerTypeId]) REFERENCES [ContainerTypes] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331160854_fix3103211308')
BEGIN
    CREATE INDEX [IX_Container_ContainerCategoryId] ON [Container] ([ContainerCategoryId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331160854_fix3103211308')
BEGIN
    CREATE INDEX [IX_Container_ContainerStatusId] ON [Container] ([ContainerStatusId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331160854_fix3103211308')
BEGIN
    CREATE INDEX [IX_Container_ContainerTypeId] ON [Container] ([ContainerTypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331160854_fix3103211308')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210331160854_fix3103211308', N'5.0.4');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    ALTER TABLE [Container] DROP CONSTRAINT [FK_Container_ContainerCategory_ContainerCategoryId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    ALTER TABLE [Container] DROP CONSTRAINT [FK_Container_ContainerStatus_ContainerStatusId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    ALTER TABLE [Container] DROP CONSTRAINT [FK_Container_ContainerTypes_ContainerTypeId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    ALTER TABLE [ContainerStatus] DROP CONSTRAINT [PK_ContainerStatus];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    ALTER TABLE [ContainerCategory] DROP CONSTRAINT [PK_ContainerCategory];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    ALTER TABLE [Container] DROP CONSTRAINT [PK_Container];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    EXEC sp_rename N'[ContainerStatus]', N'ContainerStatuses';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    EXEC sp_rename N'[ContainerCategory]', N'ContainerCategories';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    EXEC sp_rename N'[Container]', N'Containers';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    EXEC sp_rename N'[Containers].[IX_Container_ContainerTypeId]', N'IX_Containers_ContainerTypeId', N'INDEX';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    EXEC sp_rename N'[Containers].[IX_Container_ContainerStatusId]', N'IX_Containers_ContainerStatusId', N'INDEX';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    EXEC sp_rename N'[Containers].[IX_Container_ContainerCategoryId]', N'IX_Containers_ContainerCategoryId', N'INDEX';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    ALTER TABLE [ContainerStatuses] ADD CONSTRAINT [PK_ContainerStatuses] PRIMARY KEY ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    ALTER TABLE [ContainerCategories] ADD CONSTRAINT [PK_ContainerCategories] PRIMARY KEY ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    ALTER TABLE [Containers] ADD CONSTRAINT [PK_Containers] PRIMARY KEY ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    CREATE TABLE [MovType] (
        [Id] int NOT NULL IDENTITY,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_MovType] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    CREATE TABLE [Movimentations] (
        [Id] int NOT NULL IDENTITY,
        [MovTypeId] int NOT NULL,
        [Dt_Init] datetime2 NOT NULL,
        [Dt_Fin] datetime2 NOT NULL,
        CONSTRAINT [PK_Movimentations] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Movimentations_MovType_MovTypeId] FOREIGN KEY ([MovTypeId]) REFERENCES [MovType] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    CREATE INDEX [IX_Movimentations_MovTypeId] ON [Movimentations] ([MovTypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    ALTER TABLE [Containers] ADD CONSTRAINT [FK_Containers_ContainerCategories_ContainerCategoryId] FOREIGN KEY ([ContainerCategoryId]) REFERENCES [ContainerCategories] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    ALTER TABLE [Containers] ADD CONSTRAINT [FK_Containers_ContainerStatuses_ContainerStatusId] FOREIGN KEY ([ContainerStatusId]) REFERENCES [ContainerStatuses] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    ALTER TABLE [Containers] ADD CONSTRAINT [FK_Containers_ContainerTypes_ContainerTypeId] FOREIGN KEY ([ContainerTypeId]) REFERENCES [ContainerTypes] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331161209_fix3103211312')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210331161209_fix3103211312', N'5.0.4');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331172322_fix3103211423')
BEGIN
    ALTER TABLE [Movimentations] DROP CONSTRAINT [FK_Movimentations_MovType_MovTypeId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331172322_fix3103211423')
BEGIN
    ALTER TABLE [MovType] DROP CONSTRAINT [PK_MovType];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331172322_fix3103211423')
BEGIN
    EXEC sp_rename N'[MovType]', N'MovTypes';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331172322_fix3103211423')
BEGIN
    ALTER TABLE [MovTypes] ADD CONSTRAINT [PK_MovTypes] PRIMARY KEY ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331172322_fix3103211423')
BEGIN
    ALTER TABLE [Movimentations] ADD CONSTRAINT [FK_Movimentations_MovTypes_MovTypeId] FOREIGN KEY ([MovTypeId]) REFERENCES [MovTypes] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331172322_fix3103211423')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210331172322_fix3103211423', N'5.0.4');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331192035_fix3103211620')
BEGIN
    ALTER TABLE [Movimentations] ADD [ContainerId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331192035_fix3103211620')
BEGIN
    CREATE INDEX [IX_Movimentations_ContainerId] ON [Movimentations] ([ContainerId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331192035_fix3103211620')
BEGIN
    ALTER TABLE [Movimentations] ADD CONSTRAINT [FK_Movimentations_Containers_ContainerId] FOREIGN KEY ([ContainerId]) REFERENCES [Containers] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331192035_fix3103211620')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210331192035_fix3103211620', N'5.0.4');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331194632_fix3103211646')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210331194632_fix3103211646', N'5.0.4');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210331194801_fix3103211647')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210331194801_fix3103211647', N'5.0.4');
END;
GO

COMMIT;
GO

