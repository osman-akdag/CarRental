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
            //AddUser();
            //AddCustomer();
        }
        private static void ListBrands()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success)
            {   
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.Name);
                }
            }
        }

        private static void ListCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAllByCarDetails();

            if (result.Success) 
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.CarName + "-" + item.ColorName);
                }
            }
        }

        private static void AddCar()
        {
            CarManager carManager  = new CarManager(new EfCarDal());
            Car car = new Car
            {
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 300,
                ModelYear = "2018",
            };

            var result1 = carManager.Add(car);
            if (result1.Success)
            {
                Console.WriteLine(result1.Message);
            }

        }

        private static void AddCustomer()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer user = new Customer
            {
                UserId = 1                
            };

            var result = customerManager.Add(user);
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void AddUser()   
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user = new User
            {
                Email="osmanakdag.iletisim@gmail.com",
                Name="Osman",
                LastName="Akdağ",
                Password="123456789"
            };

            var result = userManager.Add(user);
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
