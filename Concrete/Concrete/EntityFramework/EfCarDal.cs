using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RentACarContext context = new RentACarContext())//using içersine yazılan nesneler using bitince anında garbage collectora geliyor beni bellekten at diyor
            //yani nothwind context bellekten işi bitince atılacak
            {
                var addedEntity = context.Entry(entity);//git verikaynağından benim gönderdiğim productla bir nesneyi eşlelştir
                //ama bu bir ekleme olacağı için herhangi bir şeyi eşleştirmiycek onun yerine direkt ekliyecek
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (RentACarContext context = new RentACarContext())//using içersine yazılan nesneler using bitince anında garbage collectora geliyor beni bellekten at diyor
            //yani nothwind context bellekten işi bitince atılacak
            {
                var deletedEntity = context.Entry(entity);//git verikaynağından benim gönderdiğim productla bir nesneyi eşlelştir
                //ama bu bir ekleme olacağı için herhangi bir şeyi eşleştirmiycek onun yerine direkt ekliyecek
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                //filtre null ise               tümünü getir  :değilse           
                 return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
                
            }
        }

        public void Update(Car entity)
        {
            using (RentACarContext context = new RentACarContext())//using içersine yazılan nesneler using bitince anında garbage collectora geliyor beni bellekten at diyor
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
