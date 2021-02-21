using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _catgoryDal;

        public CategoryManager(ICategoryDal catgoryDal)
        {
            _catgoryDal = catgoryDal;
        }

        public List<Category> GetAll()
        {
            return _catgoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _catgoryDal.Get(c => c.CategoryID == categoryId);
        }
    }
}
