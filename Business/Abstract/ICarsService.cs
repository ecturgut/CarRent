using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarsService
    {
        List<Cars> GetAll();
        void Add(Cars car);
        List<Cars> GetCarsByBrandId(int id);
        List<Cars> GetCarsByColordId(int id);
        List<Cars> GetByDailyPrice(int min, int max);
        List<CarsDetailDto> GetCarsDetails();
    }
}
