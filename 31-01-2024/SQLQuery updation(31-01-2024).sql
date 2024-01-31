-----------------------UPDATION-------------------------------------------------


create procedure updateTag
         @TagId int,
         @Name  nvarchar(100)
         
as
begin
     update dbo.Tag
	 set Name = @Name
	 where TagId = @TagId;
     
end;
    exec updateTag  @Name = 'vysh',@TagId = 103;
	-----------------------------------------------------------------------------------------------------
