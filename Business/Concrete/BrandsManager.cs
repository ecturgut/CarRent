using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandsManager : IBrandsService
    {
        IBrandsDal _brandsDal;
        public BrandsManager(IBrandsDal brandsDal)
        {
            _brandsDal = brandsDal;
        }

        public void Add(Brands brand)
        {
            _brandsDal.Add(brand); 
        }

        public List<Brands> GetAllBrands()
        {
            return _brandsDal.GetAll();
        }

        public Brands GetCarBransBydId(int brandId)
        {
            var result=  _brandsDal.Get(b => b.Id == brandId);
            return result;        }
    }
}
