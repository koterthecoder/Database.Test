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

namespace Database.Test.Controllers
{
    public class CarsController : ApiController
    {
        private ICarsManagementService _service;

        public CarsController(ICarsManagementService service)
        {
            this._service = service;
        }

        // GET api/<controller>
        public IEnumerable<Car> Get()
        {
            return _service.GetAll();
        }

        // GET api/<controller>/5
        public Car Get(long id)
        {
            return _service.GetById(id);
        }

        // POST api/<controller>
        public void Post([FromBody]IncomingCar car)
        {
            var newCar = _service.Upsert(CarFactory.CreateCar(car.LicenseNumber));

            Console.WriteLine(newCar);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }



}