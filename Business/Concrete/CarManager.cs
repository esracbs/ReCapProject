using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        //bir iş sınıfı başka sınıfları newlemez
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new Result(true, "ürün eklendi");
            //if (car.Descriptions.Length > 2 && car.DailyPrice > 0)
            //{
            //    Console.WriteLine("Araba eklendi....Algoritmik");
            //    _carDal.Add(car);
            //    return new Result();
            //}
            //else
            //{
            //    return Console.WriteLine("Araba eklenemedi. Araba ismi minimum 2 karakter olmalıdır ve Araba günlük fiyatı 0'dan büyük olmalıdır.");
            //}
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsBycolorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
    }
}
