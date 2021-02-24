using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>//class referans tip olması şartını koştu
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)

        {
            using (TContext context = new TContext())//using içersine yazılan nesneler using bitince anında garbage collectora geliyor beni bellekten at diyor
                                                     //yani nothwind context bellekten işi bitince atılacak
            {
                var addedEntity = context.Entry(entity);//git verikaynağından benim gönderdiğim productla bir nesneyi eşlelştir
                //ama bu bir ekleme olacağı için herhangi bir şeyi eşleştirmiycek onun yerine direkt ekliyecek
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())//using içersine yazılan nesneler using bitince anında garbage collectora geliyor beni bellekten at diyor
                                                     //yani nothwind context bellekten işi bitince atılacak
            {
                var deletedEntity = context.Entry(entity);//git verikaynağından benim gönderdiğim productla bir nesneyi eşlelştir
                //ama bu bir ekleme olacağı için herhangi bir şeyi eşleştirmiycek onun yerine direkt ekliyecek
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                //filtre null ise          tümünü getir       :değilse           
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())//using içersine yazılan nesneler using bitince anında garbage collectora geliyor beni bellekten at diyor
                                                     //yani nothwind context bellekten işi bitince atılacak
            {
                var updatedEntity = context.Entry(entity);//git verikaynağından benim gönderdiğim productla bir nesneyi eşlelştir
                //ama bu bir ekleme olacağı için herhangi bir şeyi eşleştirmiycek onun yerine direkt ekliyecek
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
