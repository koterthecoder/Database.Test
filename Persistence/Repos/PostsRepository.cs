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
    public class PostsRepository : IRepository<Post>
    {
        private readonly DomainContext _context;

        public PostsRepository(DomainContext context)
        {
            _context = context;
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts;
        }

        public Post GetById(long id)
        {
            return _context.Posts.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public void Add(Post objectToAdd)
        {
            _context.Posts.Add(objectToAdd);
            _context.SaveChanges();
        }

        public void Update(Post objectToUpdate)
        {
            _context.Entry(objectToUpdate).State = EntityState.Modified;
            _context.Entry(objectToUpdate).State = objectToUpdate.Id == 0 ? EntityState.Added : EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
