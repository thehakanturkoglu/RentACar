using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (var context = new RentACarContext())
            {
                var result = from cr in context.Cars
                             join m in context.Models on cr.ModelId equals m.Id
                             join b in context.Brands on m.BrandId equals b.Id
                             join cl in context.Colors on cr.ColorId equals cl.Id
                             select new CarDetailsDto
                             {
                                 CarId = cr.Id,
                                 BrandName = b.Name,
                                 ModelName = m.Name,
                                 ColorName = cl.Name,
                                 Description = cr.Description,
                                 DailyPrice = cr.DailyPrice,
                                 Kilometer = cr.Kilometer,
                                 ModelYear = cr.ModelYear
                             };

                return result.ToList();
            }    
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            using (var context = new RentACarContext())
            {
                var result = from cr in context.Cars
                             join m in context.Models on cr.ModelId equals m.Id
                             where m.BrandId == brandId select cr;

                return result.ToList();
            }
        }
    }

}
