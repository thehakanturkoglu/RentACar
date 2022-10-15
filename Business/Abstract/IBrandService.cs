using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetById(int brandId);
        bool Add(Brand brand);
        bool Delete(Brand brand);
        bool Update(Brand brand);
    }

}
