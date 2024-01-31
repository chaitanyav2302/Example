create procedure SelectUser
         
as
begin
     select * from users;
end;
    exec SelectUser;