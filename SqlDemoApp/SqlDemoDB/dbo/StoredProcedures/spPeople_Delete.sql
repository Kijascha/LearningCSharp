CREATE PROCEDURE [dbo].[spPeople_Delete]
	@Id int
AS
begin 
	delete
	from dbo.[PeopleTable]
	where Id = @Id;
end
