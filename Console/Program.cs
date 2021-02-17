using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                // Console.WriteLine("Adı:" + car.Description +" "+ car.Id + " " + 
                //    car.ModelYear + " " + car.DailyPrice + " " + car.ColorId + " " + car.BrandId);
                System.Console.WriteLine(car.Descriptions + " " + car.DailyPrice + " TL");
                System.Console.WriteLine("----------------------------");
            }
            //carManager.Add(new Car { BrandId = 4, ColorId = 4, CarName = "CarName2", ModelYear = 2004, DailyPrice = 2000, Description = "Description4" });
        }
    }
}
