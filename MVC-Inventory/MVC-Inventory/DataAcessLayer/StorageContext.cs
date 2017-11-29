using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Inventory.DataAcessLayer
{
    public class StorageContext: DbContext
    {
        public StorageContext() : base ("MVC-Inventory")
        { }

        public DbSet<Models.Product> Products { get; set; }
    }
}