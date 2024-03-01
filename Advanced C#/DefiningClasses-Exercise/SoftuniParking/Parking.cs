using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SoftUniParking
{
    public class Parking
    {
        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new List<Car>();
        }
        public List<Car> cars { get; set; }

        public int Count
        {
            get => cars.Count;
        }

        public string AddCar(Car car)
        {
            if (cars.Exists(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if (cars.Count == capacity)
            {
                return "Parking is full!";
            }
            cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            if (cars.Exists(x => x.RegistrationNumber == registrationNumber) == false)
            {
                return "Car with that registration number, doesn't exist!";
            }

            cars.RemoveAll(x => x.RegistrationNumber == registrationNumber);
            return $"Successfully removed {registrationNumber}";
        }

        public Car GetCar(string registrationnumber)
        {
            return cars.FirstOrDefault(x => x.RegistrationNumber == registrationnumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var registrationNumber in RegistrationNumbers)
            {
                if (cars.Exists(x => x.RegistrationNumber == registrationNumber))
                {
                    cars.RemoveAll(x => x.RegistrationNumber == registrationNumber);
                }
            }
        }
    }
}
