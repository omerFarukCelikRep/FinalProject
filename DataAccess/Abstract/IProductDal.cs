using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        //Methods Default Acces Modifiers => Public
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
