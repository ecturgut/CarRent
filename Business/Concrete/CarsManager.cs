using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public List<Cars> GetCarsByBrandId(int id)
        {
            var GetCarBrand = _CarsDal.GetAll(p=>p.BrandId==id);
            return GetCarBrand;
        }

        public List<Cars> GetCarsByColordId(int id)
        {
            var GetCarId = _CarsDal.GetAll(p => p.ColorId == id);
            return GetCarId;
        }

        public List<Cars> GetByDailyPrice(int min, int max)
        {
            return _CarsDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public List<CarsDetailDto> GetCarsDetails()
        {
            var result = _CarsDal.GetCarsDetails();
            return result;
        }

        public void Add(Cars car)
        {
            if (car.Description.Length>2 && car.DailyPrice > 0 )
            {
                _CarsDal.Add(car);
            }
            else
            {
                Console.WriteLine("Bir hata oluştu.");
            }
        }

      
    }
}
