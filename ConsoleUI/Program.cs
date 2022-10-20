using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carService = new CarManager(new EfCarDal());

            var carDetails = carService.GetCarDetails();

            foreach (var carDetail in carDetails.Data)
            {
                Console.WriteLine($"{carDetail.BrandName} {carDetail.ModelName} {carDetail.Description} {carDetail.DailyPrice}");
            }


        }

        private static void AddCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { ColorId = 1, ModelId = 3, DailyPrice = 200, Description = "Audi A3 Kiralık", Kilometer = 211, ModelYear = 2012 });
        }

        private static void AddModel()
        {
            ModelManager modelManager = new ModelManager(new EfModelDal());
            modelManager.Add(new Model { Name = "1.5 dCi Privilege" });
        }

        static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var cars = carManager.GetAll();

            foreach (var car in cars.Data)
            {
                Console.WriteLine("{0} {1}", car.Description, car.DailyPrice);
            }

        }



    }

    

}
