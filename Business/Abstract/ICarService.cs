using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        Car GetById(int carId);
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByModelId(int modelId);
        List<Car> GetCarsByColorId(int colorId);
        List<CarDetailsDto> GetCarDetails();
        bool Add(Car car);
        bool Update(Car car);
        bool Delete(Car car);
    }
}
