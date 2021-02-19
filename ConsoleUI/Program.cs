using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //var result = brandManager.GetAll();
            //if (result.Success)
            //{
            //    foreach (var brand in result.Data)
            //    {
            //        Console.WriteLine(brand.Name);
            //    }
            //}

            //Car car = new Car
            //{
            //    BrandId = 1,
            //    ColorId = 1,
            //    DailyPrice = 300,
            //    ModelYear = "2018",                
            //};

            //var result1=carManager.Add(car);
            //if (result1.Success)
            //{
            //    Console.WriteLine(result1.Message);
            //}

            //var result = carManager.GetAllByCarDetails();

            //if (result.Success)
            //{
            //    foreach (var item in result.Data)
            //    {
            //        Console.WriteLine(item.CarName + "-"+item.ColorName);
            //    }
            //}

        }
    }
}
