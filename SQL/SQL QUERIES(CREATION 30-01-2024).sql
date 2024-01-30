use WordVoyager;
CREATE TABLE  users(
    UserId int primary key,
    Username nvarchar(100),
    Email nvarchar(100),
    PasswordHash nvarchar(100),
    RegistrationDate datetime);

select * from INFORMATION_SCHEMA.TABLES; /*to show the tables in the current database*/

CREATE TABLE Article (
    ArticleId int primary key,
    Title nvarchar(100),
    Content text,
    PublishedDate datetime,
    LastModifiedDate datetime,
    AuthorId int,
    CategoryId int,
    foreign key(AuthorId) references users(UserId),
    foreign key (CategoryId) references category(CategoryId)
);

CREATE TABLE category (
    CategoryId int primary key,
    Name nvarchar(100),
     Description  text
);

CREATE TABLE comment (
    CommentId INT primary key,
    ArticleId INT,
    UserId INT,
    Content TEXT,
    CommentDate DATETIME,
    foreign key (ArticleId) references article(ArticleId),
    foreign key (UserId) references users(UserId)
);
CREATE TABLE ArticleTag (
    ArticleId int,
    TagId int,
    primary key(ArticleId, TagId),
    foreign key (ArticleId) references article(ArticleId),
    foreign key (TagId) references tag(TagId)
);
CREATE TABLE tag (
    TagId INT primary key,
    Name NVARCHAR(100)
);
CREATE TABLE attachment (
    AttachmentId INT primary key,
    ArticleId INT,
    FileName VARCHAR(100),
    FileType VARCHAR(100),
    FilePath NVARCHAR(100),
    UploadDate DATETIME,
    foreign key (ArticleId) references article(ArticleId)
);



sp_help 'tag' ;
 sp_rename 'attachment','Attachment';
sp_rename 'tag','Tag';
sp_rename 'category','Category';
sp_rename 'comment','Comment';

