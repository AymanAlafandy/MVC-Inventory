namespace MVC_Inventory.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_Inventory.DataAcessLayer.StorageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVC_Inventory.DataAcessLayer.StorageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Products.AddOrUpdate(n => n.Name, new Product() {
                Name = "entebbe",
                Category = "Electronics",
                Count = 0,
                Price = 200,
                Shelf = "E3",
                Description = "Its a Toaster"
            });
            context.Products.AddOrUpdate(n => n.Name, new Product()
            {
                Name = "kampala",
                Category = "Electronics",
                Count = 4,
                Price = 100,
                Shelf = "E5",
                Description = "Its a radio"
            });
            context.Products.AddOrUpdate(n => n.Name, new Product()
            {
                Name = "bombo",
                Category = "village",
                Count = 8,
                Price = 250,
                Shelf = "E3",
                Description = "Its a Toaster"
            });
            context.Products.AddOrUpdate(n => n.Name, new Product()
            {
                Name = "kabulanaka",
                Category = "Electronics",
                Count = 5,
                Price = 150,
                Shelf = "E3",
                Description = "Its a county"
            });
        }
    }
}
