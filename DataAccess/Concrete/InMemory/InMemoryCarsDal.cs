using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarsDal : ICarsDal
    {
        List<Cars> _cars;
        public InMemoryCarsDal()
        {
            _cars = new List<Cars> {
                new Cars {Id=1,BrandId=1,ColorId=1,DailyPrice=250,ModelYear=2021,Description="Günlük kiralık BMW"},
                new Cars {Id=2,BrandId=2,ColorId=2,DailyPrice=350,ModelYear=2021,Description="Günlük kiralık Mercedes"},
                new Cars {Id=3,BrandId=3,ColorId=3,DailyPrice=450,ModelYear=2021,Description="Günlük kiralık Lamborghini"},
                new Cars {Id=4,BrandId=4,ColorId=4,DailyPrice=490,ModelYear=2021,Description="Günlük kiralık Aston Martin"},
                new Cars {Id=5,BrandId=5,ColorId=5,DailyPrice=550,ModelYear=2021,Description="Günlük kiralık Bentley"}
            };
        }
        public void Add(Cars cars)
        {
            _cars.Add(cars);
        }

        public void Delete(Cars cars)
        {
            Cars carsToDelete = _cars.SingleOrDefault(p=>p.Id ==cars.Id);
            _cars.Remove(carsToDelete);
        }

        public Cars Get(Expression<Func<Cars, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetAll()
        {
            return _cars; 
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetById(int id)
        {
           return _cars.Where(p => p.Id == id).ToList();
        }

        public void Update(Cars cars)
        {
            Cars carsToUpdate = _cars.SingleOrDefault(p => p.Id == cars.Id);
            carsToUpdate.Id = cars.Id;
            carsToUpdate.BrandId = cars.BrandId;
            carsToUpdate.ColorId = cars.ColorId;
            carsToUpdate.Description = cars.Description;
            carsToUpdate.DailyPrice = cars.DailyPrice;
            carsToUpdate.ModelYear = cars.ModelYear;
        }
    }
}
