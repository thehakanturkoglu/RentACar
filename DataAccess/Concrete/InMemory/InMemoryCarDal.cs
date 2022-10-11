using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = CreateCarData();
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var deleteToCar = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(deleteToCar);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.Id == carId);
        }

        public void Update(Car car)
        {
            var updateToCar = _cars.SingleOrDefault(c => c.Id == car.Id);

            updateToCar.BrandId = car.BrandId;
            updateToCar.ColorId = car.ColorId;
            updateToCar.ModelYear = car.ModelYear;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;
            
        }
        
        private List<Car> CreateCarData()
        {
            return new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 80, ModelYear = "2000", Description = "Temiz uygun fiyatlı kiralık araç."},
                new Car{Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 100, ModelYear = "2002", Description = "İki kişilik az yakıtlı kiralık araç."},
                new Car{Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 150, ModelYear = "2008", Description = "Ne yeni ne eski tam size göre kiralık araç."},
                new Car{Id = 4, BrandId = 2, ColorId = 3, DailyPrice = 120, ModelYear = "2006", Description = "Sağlıklı ve bakımlı kiralık aile aracı."},
                new Car{Id = 5, BrandId = 3, ColorId = 2, DailyPrice = 300, ModelYear = "2022", Description = "Yeni model konforlu sport araç."},
            };
        }


    }
}
