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

        public void Add(Colors color)
        {
            _colorsDal.Add(color);
        }

        public List<Colors> GetAllColors()
        {
            return _colorsDal.GetAll();
        }

        public Colors GetColorById(int colorId)
        {
            return _colorsDal.Get(c=> c.Id == colorId);
        }
    }
}
