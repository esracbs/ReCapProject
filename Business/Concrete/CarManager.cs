using Business.Abstract;
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
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsBycolorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
