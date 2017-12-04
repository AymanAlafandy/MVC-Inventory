using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Inventory.Models.View_Models
{
    public class ProductsOutOfStocks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public ProductsOutOfStocks()
    {

    }
    public ProductsOutOfStocks(Product product)
    {
        Id = product.Id;
        Name= product.Name;
        Description = product.Description;

    }
}