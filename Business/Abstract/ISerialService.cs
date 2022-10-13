using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISerialService
    {
        List<Serial> GetAll();
        
    }
}
