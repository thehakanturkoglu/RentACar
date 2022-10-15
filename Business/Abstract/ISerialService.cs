using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISerialService
    {
        List<Serial> GetAll();
        Serial GetById(int serialId);
        bool Add(Serial serial);
        bool Delete(Serial serial);
        bool Update(Serial serial);
    }

}
