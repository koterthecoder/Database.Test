using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Impl
{
    public class CarsManagementService : ICarsManagementService
    {

        private IRepository<Car> _repo;

        public CarsManagementService(IRepository<Car> repo)
        {
            _repo = repo;
        }

        public IEnumerable<Car> GetAll()
        {
            return _repo.GetAll();
        }


        public Car GetById(long id)
        {
            if (id <= 0)
            {
                return null;
            }
            return _repo.GetById(id);
        }

        public Car Upsert(Car item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            if (item.Id == 0)
            {
                _repo.Add(item);
            }
            else
            {
                _repo.Update(item);
            }

            return item;
        }
    }
}
