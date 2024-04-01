using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TASKClass
{
    internal class Gallery
    {
        Car[] cars = new Car[0];
        public int Id { get; set; }
        public string Name { get; set; }

        public void AddCAr(Car car)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = car;
        }
        public void ShowAllCars()
        {
            foreach (Car car in cars)
            {
                if (car != null)
                {
                    Console.WriteLine($"Id: {car.Id}, Name: {car.Name}, Speed: {car.Speed}, CarCode: {car.CarCode}");
                }
            }
        }
        public Car[] GetAllCArs()
        {
            Car[] allCars = new Car[0];
            for (int i = 0; i < cars.Length; i++)
            {
                allCars[i] = cars[i];
            }
            return allCars;
        }
        public Car FindCarById(int id)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Id == id)
                {
                    return cars[i];
                }
            }
            return null;
        }
        public Car FindCarByCarCode(string carCode)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].CarCode == carCode)
                {
                    return cars[i];
                }
            }
            return null;
        }
        public Car[] FindCarsBySpeedInterval(int minSpeed, int maxSpeed)
        {
            Car[] newcars = new Car[0];
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Speed >= minSpeed && cars[i].Speed <= maxSpeed)
                {
                    Array.Resize(ref newcars, newcars.Length + 1);
                    newcars[newcars.Length - 1] = cars[i];
                }
            }

            return newcars;
        }



    }
}