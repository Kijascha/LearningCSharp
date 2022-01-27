CREATE PROCEDURE [dbo].[spPeople_Get]
	@Id int
AS
begin
	select Id, FirstName, LastName 
	from dbo.[PeopleTable]
	where Id = @Id;
end
