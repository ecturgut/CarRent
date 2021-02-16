using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandsDal;
        public BrandManager(IBrandDal brandsDal)
        {
            _brandsDal = brandsDal;
        }

        public void Add(Brand brand)
        {
            _brandsDal.Add(brand); 
        }

        public List<Brand> GetAllBrands()
        {
            return _brandsDal.GetAll();
        }

        public Brand GetCarBransBydId(int brandId)
        {
            var result=  _brandsDal.Get(b => b.Id == brandId);
            return result;        }
    }
}
