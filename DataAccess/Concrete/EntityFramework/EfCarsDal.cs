using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarsDal : EfEntityRepositoryBase<Cars, CarRentContext>, ICarsDal
    {
        public List<CarsDetailDto> GetCarsDetails()
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from c in context.Cars
                             join cc in context.Colors
                             on c.ColorId equals cc.Id
                             select new CarsDetailDto
                             {
                                 Id = c.Id,
                                 ColorId = c.ColorId,
                                 BrandId = c.BrandId,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description
                             };
                return result.ToList();
            }
        }
    }
}
