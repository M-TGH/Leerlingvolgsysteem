using Leerlingvolgsysteem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leerlingvolgsysteem.Models.Services.Database
{
    public class DatabaseConnection
    {
        public Database1Entities dbContext;

        public DatabaseConnection()
        {
            this.dbContext = new Database1Entities();
        }
    }
}