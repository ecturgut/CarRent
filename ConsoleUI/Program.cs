using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarsManager carsManager = new CarsManager(new InMemoryCarsDal());

            foreach (var cars in carsManager.GetAll())
            {
                Console.WriteLine(cars.Description);
            }
            
        }
    }
}
