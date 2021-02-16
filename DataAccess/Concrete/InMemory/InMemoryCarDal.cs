using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car {Id=1,BrandId=1,ColorId=1,DailyPrice=250,ModelYear=2021,Description="Günlük kiralık BMW"},
                new Car {Id=2,BrandId=2,ColorId=2,DailyPrice=350,ModelYear=2021,Description="Günlük kiralık Mercedes"},
                new Car {Id=3,BrandId=3,ColorId=3,DailyPrice=450,ModelYear=2021,Description="Günlük kiralık Lamborghini"},
                new Car {Id=4,BrandId=4,ColorId=4,DailyPrice=490,ModelYear=2021,Description="Günlük kiralık Aston Martin"},
                new Car {Id=5,BrandId=5,ColorId=5,DailyPrice=550,ModelYear=2021,Description="Günlük kiralık Bentley"}
            };
        }
        public void Add(Car cars)
        {
            _cars.Add(cars);
        }

        public void Delete(Car cars)
        {
            Car carsToDelete = _cars.SingleOrDefault(p=>p.Id ==cars.Id);
            _cars.Remove(carsToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars; 
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
           return _cars.Where(p => p.Id == id).ToList();
        }

        public List<CarsDetailDto> GetCarsDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car cars)
        {
            Car carsToUpdate = _cars.SingleOrDefault(p => p.Id == cars.Id);
            carsToUpdate.Id = cars.Id;
            carsToUpdate.BrandId = cars.BrandId;
            carsToUpdate.ColorId = cars.ColorId;
            carsToUpdate.Description = cars.Description;
            carsToUpdate.DailyPrice = cars.DailyPrice;
            carsToUpdate.ModelYear = cars.ModelYear;
        }
    }
}
