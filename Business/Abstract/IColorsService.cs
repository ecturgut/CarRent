using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorsService
    {
        List<Colors> GetAllColors();
        Colors GetColorById(int colorId);
        void Add(Colors color);
    }
}
