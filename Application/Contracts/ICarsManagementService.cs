using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface ICarsManagementService
    {
        IEnumerable<Car> GetAll();
        Car GetById(long Id);
        Car Upsert(Car item);

    }
}
