namespace MVC_Inventory.Migrations
{
    using Models;
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

            context.Products.AddOrUpdate(n => n.Name, new Product()
            {
                Name = "Toaster",
                Price = 200,
                Category = " ELectronics",
                Shelf = "E3",
                Count = 10,
                Description = "It's a Toaster",
                Old=10
            });

            context.Products.AddOrUpdate(n => n.Name, new Product()
            {
                Name = "Oven",
                Price = 2500,
                Category = " ELectronics",
                Shelf = "E4",
                Count = 12,
                Description = "It's an Oven",
                Old = 5
            }
            );

            context.Products.AddOrUpdate(n => n.Name, new Product()
            {
                Name = "Brick",
                Price = 2,
                Category = " Building Supplies",
                Shelf = "B",
                Count = 3000,
                Description = "It's Bricks",
                Old = 11
            }
          );

            context.Products.AddOrUpdate(n => n.Name, new Product()
            {
                Name = "Watermelon",
                Price = 5,
                Category = " Fruits",
                Shelf = "F4",
                Count = 100,
                Description = "It's a Sweet fruit",
                Old = 12
            }
          );

            context.Products.AddOrUpdate(n => n.Name, new Product()
            {
                Name = "Katt",
                Price = 500,
                Category = " Animal",
                Shelf = "E6",
                Count = 50,
                Description = "It's a Cat",
                Old = 8
            }
         );
            context.Products.AddOrUpdate(n => n.Name, new Product()
            {
                Name = "Kiwi Island",
                Price = int.MaxValue,
                Category = " Island",
                Shelf = "I",
                Count = 1,
                Description = "It's a Small Island",
                Old = 7
            }
         );

        }
    }
}
