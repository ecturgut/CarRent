using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        IResult Add(Car car);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColordId(int id);
        List<Car> GetByDailyPrice(int min, int max);
        Car GetById(int carId);
        List<CarsDetailDto> GetCarDetails();
    }
}
