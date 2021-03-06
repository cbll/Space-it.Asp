﻿using System;
using System.Collections.Generic;
using System.Web.Http;
using Space_it.Core.Entities;
using Space_it.Web.Areas.Api.ApiModels;

namespace Space_it.Web.Areas.Api.Controllers
{
    [Authorize]
    [RoutePrefix("api/project")]
    public class ProjectController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<ApiProjectModel> Get()
        {
            return new List<ApiProjectModel>
            {
                new ApiProjectModel(new ProjectModel {Id = 1, Name="test", Created = DateTime.UtcNow })
            };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
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