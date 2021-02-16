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
            CarTest();
            //ColorTest();
            //BrandTest();
        }

        private static void BrandTest()
        {
            BrandManager brandsManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandsManager.GetAllBrands())
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorsManager = new ColorManager(new EfColorDal());
            foreach (var color in colorsManager.GetAllColors())
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carsManager = new CarManager(new EfCarDal());

            foreach (var cars in carsManager.GetCarsDetails())
            {
                Console.WriteLine(cars.Description + " " + "/" + " " + cars.DailyPrice);
            }
        }
    }
}
