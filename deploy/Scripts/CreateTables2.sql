CREATE TABLE [authors] (
    [_id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_authors] PRIMARY KEY ([_id])
);
GO


CREATE TABLE [books] (
    [_id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [author_id] uniqueidentifier NULL,
    CONSTRAINT [PK_books] PRIMARY KEY ([_id]),
    CONSTRAINT [FK_books_authors_author_id] FOREIGN KEY ([author_id]) REFERENCES [authors] ([_id]) ON DELETE NO ACTION
);
GO


CREATE INDEX [IX_books_author_id] ON [books] ([author_id]);
GO


