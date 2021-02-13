using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarsTest();
            //ColorsTest();
            //BrandsTest();
        }

        private static void BrandsTest()
        {
            BrandsManager brandsManager = new BrandsManager(new EfBrandsDal());
            foreach (var brand in brandsManager.GetAllBrands())
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void ColorsTest()
        {
            ColorsManager colorsManager = new ColorsManager(new EfColorsDal());
            foreach (var color in colorsManager.GetAllColors())
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void CarsTest()
        {
            CarsManager carsManager = new CarsManager(new EfCarsDal());

            foreach (var cars in carsManager.GetCarsDetails())
            {
                Console.WriteLine(cars.Description + "/" + cars.DailyPrice);
            }
        }
    }
}
