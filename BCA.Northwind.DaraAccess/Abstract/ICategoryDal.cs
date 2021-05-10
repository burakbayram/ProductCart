using BCA.Core.DataAccess;
using BCA.Nortwind.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCA.Northwind.DaraAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
