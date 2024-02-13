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
	CREATE PROCEDURE UpdateCategory
    @CategoryId INT,
    @NewName NVARCHAR(100),
    @NewDescription TEXT
AS
BEGIN
    UPDATE Category
    SET Name = @NewName,
        Description = @NewDescription
    WHERE CategoryId = @CategoryId;
END;
