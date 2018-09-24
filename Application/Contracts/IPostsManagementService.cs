using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface IPostsManagementService
    {
        IEnumerable<Post> GetAll();
        Post GetById(long Id);
        Post Upsert(Post item);

    }
}
