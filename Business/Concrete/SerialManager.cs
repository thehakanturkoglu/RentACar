using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SerialManager : ISerialService
    {
        private ISerialDal _serialDal;

        public SerialManager(ISerialDal serialDal)
        {
            _serialDal = serialDal;
        }

        public List<Serial> GetAll()
        {
            return _serialDal.GetAll();
        }
    }
}
