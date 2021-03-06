﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from c in filter== null? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands 
                             on c.BrandId equals b.Id
                             join o in context.Colors
                             on c.ColorId equals o.Id



                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 CarName = c.CarName,
                                 BrandName = b.Name,
                                 ColorName = o.Name,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Images =  (from i in context.CarImages where i.CarId == c.Id select i.ImagePath).ToList(),
                             };

                return result.ToList();


            }

        }
    }
}