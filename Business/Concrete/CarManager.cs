using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;


namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
           _carDal.Delete(car);

            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            var data = _carDal.GetAll();
            return new SuccessDataResult<List<Car>>(data);
        }

        public IDataResult<Car> GetById(int carId)
        {
            var data = _carDal.Get(c => c.Id == carId);
            return new SuccessDataResult<Car>(data);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            var data = _carDal.GetCarsByBrandId(brandId);
            return new SuccessDataResult<List<Car>>(data);

        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            var data =  _carDal.GetAll(c => c.ColorId == colorId);
            return new SuccessDataResult<List<Car>>(data);

        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            var result = _carDal.GetCarDetails();
            return new SuccessDataResult<List<CarDetailsDto>>(result);

        }

        public IDataResult<List<Car>> GetCarsByModelId(int modelId)
        {
            var result =  _carDal.GetAll(c => c.ModelId == modelId);
            return new SuccessDataResult<List<Car>>(result);

        }


    }
}
