using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        public static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());


            foreach (var car in carManager.GetAll())
            {
                Console.Write(car.Id);
                Console.Write(car.BrandId);
                Console.Write(car.ColorId);
                Console.Write(car.DailyPrice);
                Console.Write(car.ModelYear);
                Console.Write(car.Description);
                Console.WriteLine(" ");

            }


        }
    }
}