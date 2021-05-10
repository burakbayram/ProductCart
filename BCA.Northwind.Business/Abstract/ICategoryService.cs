using BCA.Nortwind.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCA.Northwind.Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
