using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public bool Add(Color color)
        {
            _colorDal.Add(color);
            return true;
        }

        public bool Delete(Color color)
        {
            _colorDal.Delete(color);
            return true;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(c => c.Id == colorId);
        }

        public bool Update(Color color)
        {
            _colorDal.Update(color);
            return true;
        }
    }


}
