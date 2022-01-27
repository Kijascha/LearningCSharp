using SqlDemoLibrary.Models;

namespace SqlDemoLibrary.Data;

public interface IPeopleData
{
   Task DeletePerson(int id);
   Task<IEnumerable<PersonModel>> GetPeople();
   Task<PersonModel?> GetPerson(int id);
   Task InsertPerson(PersonModel person);
   Task UpdatePerson(PersonModel person);
}