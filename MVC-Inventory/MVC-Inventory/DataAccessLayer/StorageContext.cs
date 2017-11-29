using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MVC_Inventory.DataAccessLayer
{
    public class StorageContext : DbContext
    {
        //MVC-Inventory is name of our Database
        public StorageContext() : base("MVC-Inventory")
        { }

        //Everything in our DB needs to be a public DbSet property.  
        //It sets something in the db
        //Each dbset becomes a table.  Here we create the Product table
        public DbSet<Models.Product> Products{get;set;}



    }
}