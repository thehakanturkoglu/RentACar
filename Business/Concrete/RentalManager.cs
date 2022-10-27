using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);

            return new SuccessResult();
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);

            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            var data = _rentalDal.GetAll();
            return new SuccessDataResult<List<Rental>>(data);
        }

        public IDataResult<List<Rental>> GetAllByCarId(int carId)
        {
            var data = _rentalDal.GetAll(r => r.CarId == carId);
            return new SuccessDataResult<List<Rental>>(data);
        }

        public IDataResult<Rental> GetById(int rentId)
        {
            var data = _rentalDal.Get(r => r.Id == rentId);
            return new SuccessDataResult<Rental>(data);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);

            return new SuccessResult();
        }
    }
}
