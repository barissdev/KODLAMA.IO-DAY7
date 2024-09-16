using Business;
using DataAccess;
using Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarManager(new InMemoryCarDal());

            Console.WriteLine("Tüm Arabalar:");
            foreach (var car in carService.GetAll())
            {
                Console.WriteLine($"{car.Id} - {car.Description} - {car.DailyPrice} TL");
            }

            Console.WriteLine("\nYeni Araba Ekleme:");
            carService.Add(new Car { Id = 3, BrandId = 3, ColorId = 3, ModelYear = 2022, DailyPrice = 300, Description = "Coupe" });
            foreach (var car in carService.GetAll())
            {
                Console.WriteLine($"{car.Id} - {car.Description} - {car.DailyPrice} TL");
            }
        }
    }
}
