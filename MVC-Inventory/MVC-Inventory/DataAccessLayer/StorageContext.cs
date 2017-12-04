using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Inventory.DataAccessLayer
{
    /// <summary>
    /// 
    /// </summary>
    public class StorageContext : DbContext               //dbContext is a part of entity framework
    {
        public StorageContext () : base("MVC-Inventory")        //the string is the name of our database
        { }

        public DbSet<Models.Product> Products { get; set; }       //DbSet: to set something in our database, the properity is used in the code to be use in the database.

        public System.Data.Entity.DbSet<MVC_Inventory.Models.ViewModels.ProductsOutOfStock> ProductsOutOfStocks { get; set; }
    }                                                            //each DbSet will be one table
}