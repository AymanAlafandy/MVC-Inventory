using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Inventory.Models.ViewModels
{                                                                                                             //to control the data and for specific view of data 
    public class ProductsoutofStock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ProductsoutofStock()
        { }

        public ProductsoutofStock(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;

        }

    }
}