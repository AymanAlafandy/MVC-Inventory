namespace MVC_Inventory.Migrations
{
    using MVC_Inventory.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_Inventory.DataAccessLayer.StorageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;   //
        }

        /// <summary>
        /// this method called seed method
        /// It'll only used to seed or update the database.
        /// And it's converted to sql query 
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(MVC_Inventory.DataAccessLayer.StorageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            //Adding some prodect
            //context is the database and here we are adding a new item. Obs! don't set id because the database adds the id by itself otherwise you have doublicate.
            context.Products.AddOrUpdate( n => n.Name, 
                new Product() { Name="Toaster", Category="Electronics", Count= 0,
                    Price = 200, Shelf="E3", Description="It's a toaster"});

            context.Products.AddOrUpdate(n => n.Name,
                new Product() { Name = "Oven", Category = "Electronics", Count = 0,
                Price = 400, Shelf = "A4", Description = "It's a Oven"});

            context.Products.AddOrUpdate(n => n.Name,
                new Product() { Name = "Kiwi bird", Category = "Fruit", Count = 0,
                Price = 2, Shelf = "F6", Description = "It's a fruit" });


            context.Products.AddOrUpdate(n => n.Name,
                new Product() { Name = "Kiwi Island", Category = "Island", Count = 1,
                Price = int.MaxValue, Shelf = "F6", Description = "It's a small island" });

        }                                                                    
    }
}
