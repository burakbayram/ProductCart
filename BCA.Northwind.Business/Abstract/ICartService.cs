using BCA.Nortwind.Entities;
using BCA.Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCA.Northwind.Business.Abstract
{
   public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveToCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);

    }
}
