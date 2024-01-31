use WordVoyager;


  create procedure Iuser
	@UserId int,
	@UserName nvarchar(100),
	@Email nvarchar(100),
	@PasswordHash varchar(100),
	@RegistrationDate datetime
as
begin
	insert into dbo.users(UserId,UserName,Email,PasswordHash,RegistrationDate) 
	values (@UserId,@UserName,@Email,@PasswordHash,@RegistrationDate)
end;
   exec  Iuser 1, 'vysh', 'chait@gmail.com', 'sghft4dw5rd', '2024-06-12 10:23:23 AM';
   exec  Iuser 2, 'moh', 'moh@gmail.com', 'mssu8wwwwwndw', '2024-11-29 12:34:09 PM';
   exec  Iuser 3, 'alexa', 'alexa@epam.com', 'sjkawdu8W', '2024-10-13 7:00:09 AM';
   exec  Iuser 4, 'zac', 'zac@yahoo.com', 'zgq7uq4dw5rd', '2024-06-05 11:34:10 PM';
   exec  Iuser 5, 'gam', 'gam@gmail.com', 'bgdy4dw5rd', '2024-04-23 8:34:09 PM';

  SELECT * FROM users;
------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------

  create procedure ITag
	@TagId int,
	@Name nvarchar(100)
	
as
begin
	insert into dbo.Tag(TagId,Name) 
	values (@TagId,@Name)
end;
 
   exec ITag 101,'harry';
   exec ITag  102,'jack';
   exec ITag  103,null ;
   exec ITag 104,'geoffery';
   exec ITag 105,'rac';
  
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
create procedure IComment
	@CommentId int,
	@ArticleId int,
	@UserId int,
	@Content text,
	@CommentDate datetime
as
begin
	insert into dbo.Comment(CommentId,ArticleId,UserId,Content,CommentDate) 
	values (@CommentId,@ArticleId,@UserId,@Content,@CommentDate)
end;

  exec IComment 201,23,2,'hello from hyderabad','2024-06-12';
  exec IComment 202,null,null,'hello from mumbai',null;
  exec IComment 203,24,2,'hello from chennai',null;
  exec IComment 204,25,5,'hello from kolkata','2024-06-12';
  exec IComment 205,26,4,'hello from banglore','2024-06-12' ;
   select * from Comment;
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
create procedure IArticle
	
	@ArticleId int,
	@Title nvarchar(100),
	@Content text,
	@PublishedDate datetime,
	@LastModifiedDate datetime,
	@AuthorId int,
	@CategoryId int
as
begin
	insert into dbo.Article(ArticleId,Title,Content,PublishedDate,LastModifiedDate,AuthorId,CategoryId) 
	values (@ArticleId,@Title,@Content,@PublishedDate,@LastModifiedDate,@AuthorId,@CategoryId)
end;


   exec IArticle 25,'mountains','about the nature','2018-06-12 ','2024-06-12 ',2,null;
   exec IArticle 22,'politics','hot topics',null,null,1,46;
   exec IArticle 23,'social service','contributions of mnc','2019-12-29 ','2024-04-08 ',5,42;
   exec IArticle 24,'mental health','anxiety issues','2024-02-24 ','2024-06-12 ',null,43;
   exec IArticle 26,'peace','UNESCO alarms','2018-06-12 ',null,3,47;
   select * from Article;
-----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------
   create procedure IArticleTag
	@ArticleId int,
	@TagId int
	
as
begin
	insert into dbo.ArticleTag(ArticleId,TagId) 
	values (@ArticleId,@TagId)
end;


   exec IArticleTag 23,101;
   exec IArticleTag 24,105;
   exec IArticleTag 22,103;
   exec IArticleTag 25,104;
   select * from ArticleTag;
   ------------------------------------------------------------------------------
   -------------------------------------------------------------------------------
    create procedure ICategory
	@CategoryId int,
	@Name nvarchar(100),
	@Description text
	
as
begin
	insert into dbo.Category(CategoryId,Name,Description) 
	values (@CategoryId,@Name,@Description)
end;

    exec ICategory 47,'peace','non violance';
    exec ICategory 46,'policalaffairs','indianpolitics';
    exec ICategory 44,'comedy','childrenseries';
    exec ICategory 43,'health',null;
    exec ICategory 45,'scifi','nolans';
    exec ICategory 42,'socialservices','thrillers';
   select * from Category;
   ---------------------------------------------------------------------------------------------------
   ---------------------------------------------------------------------------------------------------
   create procedure IsAttachment
    @AttachmentId INT,
    @ArticleId INT,
    @FileName NVARCHAR(100),
    @FileType NVARCHAR(100),
    @FilePath NVARCHAR(100)
    
AS
BEGIN
    INSERT INTO Attachment (AttachmentId, ArticleId, FileName, FileType, FilePath)
    VALUES (@AttachmentId, @ArticleId, @FileName, @FileType, @FilePath);
END;


EXEC IsAttachment 401,23, 'Introduction to SQL', 'png',null;
EXEC IsAttachment  402,23 , 'Normalization in Databases', 'jpeg',null;
EXEC IsAttachment 405, 23, 'sql_intro.pdf', 'PDF', '/attachments/sql_intro.pdf';
EXEC IsAttachment 404, 23, 'sql_diagram.png', 'Image', '/attachments/sql_diagram.png';
EXEC IsAttachment 403, 23, 'normalization_guide.pdf', 'PDF', '/attachments/normalization_guide.pdf';

 -----------------------------------------------------------------------------------------------
 --------------------------------------------------------------------------------------------------
 select * from Attachment;