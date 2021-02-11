using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarsDal
    {
        List<Cars> GetAll();
        void Add(Cars cars);
        void Update(Cars cars);
        void Delete(Cars cars);

        List<Cars> GetById(int id);

    }
}
