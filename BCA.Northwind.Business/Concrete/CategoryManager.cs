using BCA.Northwind.Business.Abstract;
using BCA.Northwind.DaraAccess.Abstract;
using BCA.Nortwind.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCA.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
