CREATE TABLE [authors] (
    [id] uniqueidentifier NOT NULL,
    [name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_authors] PRIMARY KEY ([id])
);
GO


CREATE TABLE [books] (
    [id] uniqueidentifier NOT NULL,
    [author_id] uniqueidentifier NULL,
    [name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_books] PRIMARY KEY ([id]),
    CONSTRAINT [FK_books_authors_author_id] FOREIGN KEY ([author_id]) REFERENCES [authors] ([id]) ON DELETE NO ACTION
);
GO


CREATE INDEX [IX_books_author_id] ON [books] ([author_id]);
GO


