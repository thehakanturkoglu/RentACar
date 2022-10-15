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

        public bool Add(Serial serial)
        {
            _serialDal.Add(serial);
            return true;
        }

        public bool Delete(Serial serial)
        {
           _serialDal.Delete(serial);
            return true;
        }

        public List<Serial> GetAll()
        {
            return _serialDal.GetAll();
        }

        public Serial GetById(int serialId)
        {
            return _serialDal.Get(s => s.Id == serialId);
        }

        public bool Update(Serial serial)
        {
            _serialDal.Update(serial);
            return true;
        }
    }

    

}
