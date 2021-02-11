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
            CarsManager carsManager = new CarsManager(new EfCarsDal());

            foreach (var cars in carsManager.GetAll())
            {
                Console.WriteLine(cars.Description);
            }
            
        }
    }
}
