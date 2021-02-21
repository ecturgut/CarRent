using Business.Abstract;
using Business.Constants;
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

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 21)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_CarsDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_CarsDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_CarsDal.Get(c => c.Id == carId));
        }

        public IDataResult<List<Car>> GetCarsByColordId(int id)
        {
            return new SuccessDataResult<List<Car>>(_CarsDal.GetAll(p => p.ColorId == id));

        }

        public IDataResult<List<Car>> GetByDailyPrice(int min, int max)
        {
            return new SuccessDataResult<List<Car>>(_CarsDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max));
        }

        public IDataResult<List<CarsDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarsDetailDto>>(_CarsDal.GetCarDetails());

        }

        public IResult Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
               _CarsDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
                
            }
            
            return new ErrorResult(Messages.CarNameInvalid);
        }
        public IResult Update(Car car)
        {
            _CarsDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            _CarsDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }
    }
}
