using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public bool Add(Brand brand)
        {
            _brandDal.Add(brand);
            return true;
        }

        public bool Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return true;
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b => b.Id == brandId);
        }

        public bool Update(Brand brand)
        {
            _brandDal.Update(brand);
            return true;
        }
    }


}
