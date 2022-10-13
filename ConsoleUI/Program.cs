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
            CarManager carManager = new CarManager(new EfCarDal());
            SerialManager serialManager = new SerialManager(new EfSerialDal());


            var cars = carManager.GetAll();
            var series = serialManager.GetAll();

            foreach (var car in cars)
            {
                Console.WriteLine("{0} {1}",car.Description, car.DailyPrice);
            }

            foreach (var serial in series)
            {
                Console.WriteLine(serial.Name);
            }


        }
    }
}
