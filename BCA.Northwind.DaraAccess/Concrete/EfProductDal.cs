using BCA.Core.DataAccess;
using BCA.Core.DataAccess.EntityFramework;
using BCA.Northwind.DaraAccess.Abstract;
using BCA.Nortwind.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCA.Northwind.DaraAccess.Concrete
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
    }
}
