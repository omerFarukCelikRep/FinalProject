using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic Repository Design Pattern
    //Generic Constraint => Generic Kısıt
    // class => referans tip olabilir 
    //IEntity  => IEntity olabilir yada IEntity implemente eden bir nesne olabilir
    public interface IEntityRepository<T> where T : class, IEntity
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
