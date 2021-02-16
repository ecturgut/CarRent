using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorsDal;
        public ColorManager(IColorDal colorsDal)
        {
            _colorsDal = colorsDal;
        }

        public void Add(Color color)
        {
            _colorsDal.Add(color);
        }

        public List<Color> GetAllColors()
        {
            return _colorsDal.GetAll();
        }

        public Color GetColorById(int colorId)
        {
            return _colorsDal.Get(c=> c.Id == colorId);
        }
    }
}
