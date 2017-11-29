using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;                                                              // to get this right click on references folder->add references (or) still if you dont get it,go to tools ->Nuget Package Manager->  Manage Nuget...->search for Entity in the Browse->check the project->select latest version and install

namespace MVC_Inventory.DataAccessLayer
{
    public class StorageContext : DbContext
    {
        public StorageContext() : base("MVC-Inventory")                     //this string in bet base(" ") ->name of your data base
        { }


        public DbSet<Models.Product> Products { get; set; }                //property created->dbset->set something in to our database,here we are creating table "Product for product properties" in the database

    }
}