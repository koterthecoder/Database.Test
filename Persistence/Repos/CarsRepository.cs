using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repos
{
    public class CarsRepository : IRepository<Car>
    {
        private readonly DomainContext _context;

        public CarsRepository(DomainContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetAll()
        {
            return _context.Cars;
        }

        public Car GetById(long id)
        {
            return _context.Cars.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public void Add(Car objectToAdd)
        {
            _context.Cars.Add(objectToAdd);
            _context.SaveChanges();
        }

        public void Update(Car objectToUpdate)
        {
            _context.Entry(objectToUpdate).State = EntityState.Modified;
            _context.Entry(objectToUpdate).State = objectToUpdate.Id == 0 ? EntityState.Added : EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
