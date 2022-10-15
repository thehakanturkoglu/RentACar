using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int colorId);
        bool Add(Color color);
        bool Delete(Color color);
        bool Update(Color color);
    }

}
