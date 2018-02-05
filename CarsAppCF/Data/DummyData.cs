using CarsAppCF.Models.TravelModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarsAppCF.Models;
//using CarsAppCF.Models.Model1;

namespace CarsAppCF.Data
{
    public class DummyData
    {
        public static System.Collections.Generic.List<CarType> getCarTypes()
        {
            List<CarType> cartypes = new List<CarType>()
            {
                new CarType()
                {
                    CarTypeName = "Car",
                },
                new CarType()
                {
                    CarTypeName = "Truck",
                },
            };
            return cartypes;
        }
        public static System.Collections.Generic.List<Car> getCars(Model1 context)
        {
            List<Car> cars = new List<Car>()
            {
                new Car()
                {
                    CarName = "Volvo",
                    CarTypeId = context.CarType.Find("Car").CarTypeId,
                    Consumption = 12,
                },
                new Car()
                {
                    CarName = "Toyota",
                    CarTypeId = context.CarType.Find("Car").CarTypeId,
                    Consumption = 10,
                },
            };
            return cars;
        }
    }
}