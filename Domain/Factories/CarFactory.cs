using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Domain.Factories
{
    public static class CarFactory
    {
        public static Car CreateCar(string license)
        {
            return new Car
            {
                LicenceNumber = license,
                Created = SystemTime.Current(),
                Modified = SystemTime.Current(),
            };
        }

    }
}
