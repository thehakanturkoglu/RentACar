using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        Car GetById(int carId);
        List<Car> GetAll();
        bool Add(Car car);
        bool Update(Car car);
        bool Delete(Car car);
    }
}
