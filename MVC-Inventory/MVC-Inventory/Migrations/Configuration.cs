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
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC_Inventory.DataAccessLayer.StorageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Products.AddOrUpdate(n=>n.Name,new Product()
            { Name="Toaster",Category = "Electronics",Count=0,Price=200,Shelf="E3",Description="It's a toaster"

            });
            context.Products.AddOrUpdate(n => n.Name, new Product()
            {
                Name = "Oven",
                Category = "Electronics",
                Count = 12,
                Price = 2500,
                Shelf = "A4",
                Description = "It's an Oven"

            });
            context.Products.AddOrUpdate(n => n.Name, new Product()
            {
                Name = "Brick",
                Category = "Building supplies",
                Count = 3000,
                Price = 2,
                Shelf = "B",
                Description = "It's bricks"

            });
            context.Products.AddOrUpdate(n => n.Name, new Product()
            {
                Name = "Kiwi Bird",
                Category = "Fruit",
                Count = 0,
                Price = 5,
                Shelf = "F6",
                Description = "It's a hairy fruit"

            });
            context.Products.AddOrUpdate(n => n.Name, new Product()
            {
                Name = "Kiwi Island", 
                Category = "Island",
                Count = 1,
                Price = int.MaxValue,
                Shelf = "I",
                Description = "It's small island"

            });

        }
    }
}
