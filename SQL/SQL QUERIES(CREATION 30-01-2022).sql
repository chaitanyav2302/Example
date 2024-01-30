use WordVoyager;
CREATE TABLE users(
    UserId INT PRIMARY KEY,
    Username NVARCHAR(100),
    Email NVARCHAR(100),
    PasswordHash NVARCHAR(100),
    RegistrationDate DATETIME);

select * from INFORMATION_SCHEMA.TABLES; /*to show the tables in the current database*/

CREATE TABLE Article (
    ArticleId INT PRIMARY KEY,
    Title NVARCHAR(100),
    Content TEXT,
    PublishedDate DATETIME,
    LastModifiedDate DATETIME,
    AuthorId INT,
    CategoryId INT,
    FOREIGN KEY (AuthorId) REFERENCES users(UserId),
    FOREIGN KEY (CategoryId) REFERENCES category(CategoryId)
);

CREATE TABLE category (
    CategoryId INT PRIMARY KEY,
    Name NVARCHAR(100),
    Description TEXT
);

CREATE TABLE comment (
    CommentId INT PRIMARY KEY,
    ArticleId INT,
    UserId INT,
    Content TEXT,
    CommentDate DATETIME,
    FOREIGN KEY (ArticleId) REFERENCES Article(ArticleId),
    FOREIGN KEY (UserId) REFERENCES users(UserId)
);
CREATE TABLE ArticleTag (
    ArticleId INT,
    TagId INT,
    PRIMARY KEY (ArticleId, TagId),
    FOREIGN KEY (ArticleId) REFERENCES Article(ArticleId),
    FOREIGN KEY (TagId) REFERENCES Tag(TagId)
);
CREATE TABLE tag (
    TagId INT PRIMARY KEY,
    Name NVARCHAR(100)
);
CREATE TABLE attachment (
    AttachmentId INT PRIMARY KEY,
    ArticleId INT,
    FileName VARCHAR(100),
    FileType VARCHAR(100),
    FilePath NVARCHAR(100),
    UploadDate DATETIME,
    FOREIGN KEY (ArticleId) REFERENCES Article(ArticleId)
);