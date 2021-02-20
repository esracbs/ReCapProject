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

            //Deneme();
            //ColorManagerTest();
            //BrandManagerTest();//EfBrandDal'a joinle neyi istediğimizi söylersek çıktı verecektir

        }
        
        private static void ColorManagerTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                System.Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                System.Console.WriteLine(brand.BrandName);
            }
        }

        private static void Deneme()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 2, ColorId = 1, DailyPrice = 100, Descriptions = "klklklkH", ModelYear = "2021" });
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine("Adı:" + car.Descriptions + " " + car.CarId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.ColorId + " " + car.BrandId);
                System.Console.WriteLine("----------------------------");


            }


            //carManager.GetAll();
            carManager.GetCarsByBrandId(2);
            carManager.GetCarsBycolorId(3);
            //carManager.Add(new Car { BrandId = 4, ColorId = 4, CarName = "CarName2", ModelYear = 2004, DailyPrice = 2000, Description = "Description4" });
        }
    }
}
