using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car() {CarId = 1, BrandId = 1, ColorId = 1, Descriptions = "Otomatik", ModelYear = "2010", DailyPrice = 89999.99m},
                new Car() {CarId = 2, BrandId = 1, ColorId = 2, Descriptions = "Otomatik", ModelYear = "2012", DailyPrice = 129999.99m},
                new Car() {CarId = 3, BrandId = 1, ColorId = 3, Descriptions = "Manuel", ModelYear = "2010", DailyPrice = 79999.99m},
                new Car() {CarId = 4, BrandId = 2, ColorId = 1, Descriptions = "Otomatik", ModelYear = "2010", DailyPrice = 259999.99m},
                new Car() {CarId = 5, BrandId = 2, ColorId = 2, Descriptions = "Otomatik ", ModelYear = "2010", DailyPrice = 281000}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carsToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carsToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate=_cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
        }
    }
}
