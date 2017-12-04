using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Inventory.Models.ViewModels
{
    /// <summary>
    /// you create VM because you want to limite the information you want to show.
    /// </summary>
    public class ProductsOutOfStock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductsOutOfStock() { }
        public ProductsOutOfStock(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
        }
    }
}