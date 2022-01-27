using SqlDemoLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDemoLibrary.Data;

public class PeopleData
{
   private readonly ISqlDataAccess _db;
   public PeopleData(ISqlDataAccess db)
   {
      _db = db;
   }
}
