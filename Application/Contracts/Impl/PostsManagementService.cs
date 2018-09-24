using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Impl
{
    public class PostsManagementService : IPostsManagementService
    {
        private IRepository<Post> _repo;

        public PostsManagementService(IRepository<Post> repo)
        {
            _repo = repo;
        }

        public IEnumerable<Post> GetAll()
        {
            return _repo.GetAll();
        }


        public Post GetById(long id)
        {
            if (id <= 0)
            {
                return null;
            }
            return _repo.GetById(id);
        }

        public Post Upsert(Post item)
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
