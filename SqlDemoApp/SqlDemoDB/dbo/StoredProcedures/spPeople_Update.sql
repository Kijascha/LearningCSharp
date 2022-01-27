CREATE PROCEDURE [dbo].[spPeople_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin 
	update dbo.[PeopleTable]
	set FirstName = @Firstname, LastName = @LastName
	where Id = @Id;
end
