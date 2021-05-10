using System.Collections.Generic;
using BCA.Nortwind.Entities;

namespace BCA.Northwind.MvcWebUI.Models
{
   public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}