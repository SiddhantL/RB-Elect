using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TestPostgres.Interfaces;
using TestPostgres.Models;

namespace TestPostgres.Controllers
{
    [Route("api/[controller]")]
    public class User_AuthController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public User_AuthController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
       
        [HttpGet]
        public IEnumerable<User_Auth> Get()
        {
            return _dataAccessProvider.GetUser_AuthRecords();
        }
        [HttpGet("{email}/ss%9173450rsj{password}sr5d4drs")]
        public User_Auth Details(string email,string password)
        {
            return _dataAccessProvider.GetUserAuthSingleRecord(email,password);
        }
        /*        [HttpGet, Route("/test")]
                public IActionResult Get(User_Auth user_auth)
                {
                    if (ModelState.IsValid)
                    {
                        _dataAccessProvider.AddUserAuthRecord(user_auth);
                        return Ok();
                    }
                    return BadRequest();
                }*/

        /*[HttpPost("{name}", Name = "PostExample")]
        public string Post(string name)
        {

            return name;
        }
        [HttpPost]
           public IActionResult Create([FromBody] User_Auth user_auth)
           {
               if (ModelState.IsValid)
               {
                   Guid obj = Guid.NewGuid();
                   user_auth.User_email = obj.ToString();
                   _dataAccessProvider.AddUserAuthRecord(user_auth);
                   return Ok();
               }
               return BadRequest();
           }

        

         [HttpPut]
         public IActionResult Edit([FromBody] Patient patient)
         {
             if (ModelState.IsValid)
             {
                 _dataAccessProvider.UpdatePatientRecord(patient);
                 return Ok();
             }
             return BadRequest();
         }

         [HttpDelete("{id}")]
         public IActionResult DeleteConfirmed(string id)
         {
             var data = _dataAccessProvider.GetPatientSingleRecord(id);
             if (data == null)
             {
                 return NotFound();
             }
             _dataAccessProvider.DeletePatientRecord(id);
             return Ok();
         }*/
    }
}

