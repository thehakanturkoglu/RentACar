using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public bool Add(Car car)
        {
            if (CheckCarDailyPrice(car) && CheckCarDescription(car))
            {
                _carDal.Add(car);
                return true;
            }
            return false;
            
        }

        public bool Delete(Car car)
        {
           _carDal.Delete(car);

            return true;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(c => c.Id == carId);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetCarsByBrandId(brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public bool Update(Car car)
        {
            _carDal.Update(car);
            return true;
        }

        private bool CheckCarDescription(Car car)
        {
            if (car.Description.Count() >= 2)
                return true;
            else
                return false;
        }

        private bool CheckCarDailyPrice(Car car)
        {
            if (car.DailyPrice > 0)
                return true;
            else
                return false;
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByModelId(int modelId)
        {
            return _carDal.GetAll(c => c.ModelId == modelId);
        }
    }
}
