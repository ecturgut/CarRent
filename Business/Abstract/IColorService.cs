﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAllColors();
        Color GetColorById(int colorId);
        void Add(Color color);
    }
}
