using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarsManager : ICarsService
    {
        ICarsDal _CarsDal;
        public CarsManager(ICarsDal carsDal)
        {
            _CarsDal = carsDal;
        }
        public List<Cars> GetAll()
        {
            return _CarsDal.GetAll();
        }
    }
}
