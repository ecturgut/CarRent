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

        public List<Cars> GetAllByBrandId(int id)
        {
            return _CarsDal.GetAll(p=>p.BrandId==id);
        }

        public List<Cars> GetByDailyPrice(int min, int max)
        {
            return _CarsDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }
    }
}
