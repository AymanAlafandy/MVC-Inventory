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

            context.products.AddOrUpdate(n => n.Name,
            new Product()
            {
                Name = "Toaster",
                Category = "Electronics",
                Count = 0,
                Price = 200,
                Shelf = "E3",
                Description = "It's a toaster"
            },


            new Product()
            {
                Name = "Oven",
                Category = "Electronics",
                Count = 12,
                Price = 2500,
                Shelf = "A4",
                Description = "It's an oven"
            },

            new Product()
            {
                Name = "Blick",
                Category = "Building supplies",
                Count = 3000,
                Price = 2,
                Shelf = "B",
                Description = "It's a bricks"
            },

          new Product()
          {
              Name = "Kiwi",
              Category = "Fruit",
              Count = 0,
              Price = 5,
              Shelf = "F6",
              Description = "It's a hairy fruit"
          },

         new Product()
         {
             Name = "KiwiBird",
             Category = "Bird",
             Count = 0,
             Price = 500,
             Shelf = "F6",
             Description = "It's a hairy bird"
         },

         new Product()
         {
             Name = "KiwiIsland",
             Category = "Island",
             Count = 1,
             Price = int.MaxValue,
             Shelf = "I",
             Description = "It's a small island"
         },
         
          new Product()
          {
              Name = "Katt",
              Category = "Animal",
              Count = 98,
              Price = 5,
              Shelf = "C4",
              Description = "It's a cat"
          });

        }
    }
}
