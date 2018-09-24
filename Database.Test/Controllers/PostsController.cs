using Application.Contracts;
using Application.Contracts.Impl;
using Database.Test.Models;
using Domain.Factories;
using Domain.Models;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Utilities;

namespace Database.Test.Controllers
{
    public class PostsController : ApiController
    {
        private IPostsManagementService _service;

        public PostsController(IPostsManagementService service)
        {
            this._service = service;
        }

        // GET api/<controller>
        public IEnumerable<Post> Get()
        {
            return _service.GetAll();
        }

        // GET api/<controller>/5
        public Post Get(long id)
        {
            return _service.GetById(id);
        }

        // POST api/<controller>
        public void Post([FromBody]IncomingBlog blog)
        {
            _service.Upsert(PostFactory.CreatePost(blog.Title, blog.Body));
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]IncomingBlog blog)
        {
            var updatePost = _service.GetById(id);

            updatePost.Title = blog.Title != null ? blog.Title : updatePost.Title ;
            updatePost.Body = blog.Body != null ? blog.Body : updatePost.Body;
            updatePost.Modified = SystemTime.Current();

            _service.Upsert(updatePost);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }


}