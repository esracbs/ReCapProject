using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //core katmanında evrensel kodlar yani tüm projelerde kullanılacak kodlar bulunur
    // data accessi ilgilendiren kodlar data access klasööründe bulunur
    //core katmanı diğer katmanları referans almaz
    public interface IEntityRepository<T> where T : class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);//filtreleme için kullanılır
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
