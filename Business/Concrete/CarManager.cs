using Business.Abstract;
using Core.Utilities.Results;
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

        public List<CarsDetailDto> GetCarDetails()
        {
            var result = _CarsDal.GetCarDetails();
            return result;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length>2 && car.DailyPrice > 0 )
            {
                
                return new ErrorResult("Araba ismi en az 2 karakterden oluşmalıdır.");
            }
            _CarsDal.Add(car);
            return new SuccessResult("Araba eklendi.");
        }

        public Car GetById(int carId)
        {
            return _CarsDal.Get(c=>c.Id == carId);
        }
    }
}
