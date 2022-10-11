using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            
            var cars = carManager.GetAll();

            carManager.Add(new Car { Id = 6, DailyPrice = 180, Description = "Kendine göre SUV arayanlar için kiralık araç."});
            carManager.Delete(new Car { Id = 6});
            carManager.Update(new Car { Id = 5, DailyPrice = 350, Description = "Yeni model konforlu sport araç." });

            foreach (var car in cars)
            {
                Console.WriteLine(car.Description + " Fiyat: " + car.DailyPrice);
            }

        }
    }
}
