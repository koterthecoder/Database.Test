using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Domain.Factories
{
    public static class PostFactory
    {
        public static Post CreatePost(string title, string body)
        {
            return new Post
            {
                Title = title,
                Body = body,
                Created = SystemTime.Current(),
                Modified = SystemTime.Current(),
            };
        }
        public static Post CreatePost(long id, string title, string body)
        {
            return new Post
            {
                Id = id,
                Title = title,
                Body = body,
                Created = SystemTime.Current(),
                Modified = SystemTime.Current(),
            };
        }

    }
}
