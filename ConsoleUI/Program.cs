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
            CarsTest();
            //ColorsTest();
        }

        private static void ColorsTest()
        {
            ColorsManager colorsManager = new ColorsManager(new EfColorsDal());
            foreach (var color in colorsManager.GetAll())
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
