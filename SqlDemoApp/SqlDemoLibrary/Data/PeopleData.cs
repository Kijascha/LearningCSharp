using SqlDemoLibrary.DataAccess;
using SqlDemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDemoLibrary.Data;

public class PeopleData : IPeopleData
{
   private readonly ISqlDataAccess _db;
   public PeopleData(ISqlDataAccess db)
   {
      _db = db;
   }
   public Task<IEnumerable<PersonModel>> GetPeople() =>
      _db.LoadData<PersonModel, dynamic>("dbo.spPeople_GetAll", new { });

   public async Task<PersonModel?> GetPerson(int id)
   {
      var results = await _db.LoadData<PersonModel, dynamic>("dbo.spPeople_Get", new { Id = id });
      return results.FirstOrDefault();
   }

   public Task InsertPerson(PersonModel person) =>
      _db.SaveData("dbo.spPeople_Insert", new { person.FirstName, person.LastName });

   public Task UpdatePerson(PersonModel person) =>
      _db.SaveData("dbo.spPeople_Update", person);

   public Task DeletePerson(int id) =>
      _db.SaveData("dbo.spPeople_Delete", new { Id = id });
}
