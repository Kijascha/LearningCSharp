if not exists(select 1 from dbo.[PeopleTable])
begin	
	insert into dbo.[PeopleTable] (FirstName, LastName)
	values ('Uwe','Prehn'),
	('Tim','Corey'),
	('Sue','Storm'),
	('John','Jones');
end