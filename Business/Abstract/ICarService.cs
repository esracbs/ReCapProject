using Core.Utilities.Results;
using Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsBycolorId(int id);
        IResult Add(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
