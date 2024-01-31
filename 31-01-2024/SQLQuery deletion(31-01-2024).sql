 create procedure  Dlusers
    @UserId int
as
begin                                                 
    DELETE FROM dbo.users WHERE UserId = @UserId;
end;
      exec Dlusers 4;


-------------------------------------------------------------------------------------------------------
create procedure  DeleteUsersRnge
    @start int,
	@end   int
as
begin 
    DELETE FROM dbo.Article WHERE AuthorId  between @start and @end;                                                             --it is used to delete the records from the table
    DELETE FROM dbo.users WHERE UserId  between @start and @end;
end;
      exec DeleteUsersRnge 1,3;
	  select * from users;
------------------------------------------------------------------------------------------
create procedure  DeleteArticle
    @Start varchar(10)
as
begin                                                  
    DELETE FROM dbo.Article WHERE Title like @Start;
end;
      exec DeleteArticle  @Start = "m%";


	  select *from Attachment;
--------------------------------------------------------------------------------------------------------
create procedure  Dattach
    
as
begin                                                 
    DELETE FROM dbo.Attachment WHERE FilePath IS NULL;
end;
   exec Dattach;
----------------------------------------------------------------------------------------------------------