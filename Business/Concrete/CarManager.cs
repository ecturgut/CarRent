using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarsDal;
        public CarManager(ICarDal carsDal)
        {
            _CarsDal = carsDal;
        }
        public List<Car> GetAll()
        {
            return _CarsDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            var GetCarBrand = _CarsDal.GetAll(p=>p.BrandId==id);
            return GetCarBrand;
        }

        public List<Car> GetCarsByColordId(int id)
        {
            var GetCarId = _CarsDal.GetAll(p => p.ColorId == id);
            return GetCarId;
        }

        public List<Car> GetByDailyPrice(int min, int max)
        {
            return _CarsDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public List<CarsDetailDto> GetCarsDetails()
        {
            var result = _CarsDal.GetCarsDetails();
            return result;
        }

        public void Add(Car car)
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
