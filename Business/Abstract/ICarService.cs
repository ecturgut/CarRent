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
        IDataResult <List<Car>> GetAll();
        IDataResult <List<CarDetailDto>> GetCarDetails();
        IDataResult <List<CarDetailDto>> GetByBrandId(int id);
        IDataResult <List<CarDetailDto>> GetByColorId(int id);
        IDataResult <Car> GetById(int carId);
        IResult AddTransactionalTest(Car car);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
