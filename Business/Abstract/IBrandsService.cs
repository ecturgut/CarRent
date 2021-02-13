using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandsService
    {
        List<Brands> GetAllBrands();
        Brands GetCarBransBydId(int brandId);
        void Add(Brands brand);
    }
}
