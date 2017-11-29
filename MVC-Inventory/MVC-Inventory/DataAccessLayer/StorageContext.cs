using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Inventory.DataAccessLayer
{
    public class StorageContext : DbContext
    {
        public StorageContext() : base("MVC-Inventory")
        { }
         //Dbset set some in to database
        public DbSet<Models.Product> products {get;set;}
    }
}