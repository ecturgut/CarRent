using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorsManager : IColorsService
    {
        IColorsDal _colorsDal;
        public ColorsManager(IColorsDal colorsDal)
        {
            _colorsDal = colorsDal;
        }
        public List<Colors> GetAll()
        {
            return _colorsDal.GetAll();
        }

        public Colors GetCarsByColorId(int colorId)
        {
            return _colorsDal.Get(c=> c.Id == colorId);
        }
    }
}
