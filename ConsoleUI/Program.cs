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

            ModelManager modelManager = new ModelManager(new EfModelDal());
            modelManager.Add(new Model { Name = "1.5 dCi Privilege" });

            SerialManager serialManager = new SerialManager(new EfSerialDal());
            serialManager.Add(new Serial { Name = "A3" });

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car {BrandId = 2, ColorId = 1, ModelId = 3, SerialId = 4, DailyPrice = 200, Description = "Audi A3 Kiralık", Kilometer = 211,ModelYear = 2012 });
        }

        static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var cars = carManager.GetAll();

            foreach (var car in cars)
            {
                Console.WriteLine("{0} {1}", car.Description, car.DailyPrice);
            }

        }


        static void SerialGetAll()
        {
            SerialManager serialManager = new SerialManager(new EfSerialDal());

            var series = serialManager.GetAll();

            foreach (var serial in series)
            {
                Console.WriteLine(serial.Name);
            }
        }

    }

    

}
