using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestPostgres.Interfaces;
using TestPostgres.Models;

namespace TestPostgres.Controllers
{
    [Route("api/[controller]")]
    public class Genset_incoming_dataController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public Genset_incoming_dataController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public IEnumerable<Genset_incoming_data> Get()
        {
            return _dataAccessProvider.GetGensetIncomingDataRecords();
        }

        [HttpGet, Route("/addData")]
        public IActionResult Get(Genset_incoming_data insert)
        {
            if (ModelState.IsValid)
            {
                
                insert.Timestamp = DateTime.Now;
                _dataAccessProvider.AddGensetIncomingData(insert);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public Genset_incoming_data Details(string id)
        {
            return _dataAccessProvider.GetGensetIncomingDataSingleRecord(id);
        }

        /*   [HttpPost]
           public IActionResult Create([FromBody] Patient patient)
           {
               if (ModelState.IsValid)
               {
                   Guid obj = Guid.NewGuid();
                   patient.id = obj.ToString();
                   _dataAccessProvider.AddPatientRecord(patient);
                   return Ok();
               }
               return BadRequest();
           }

           [HttpGet("{id}")]
           public Patient Details(string id)
           {
               return _dataAccessProvider.GetPatientSingleRecord(id);
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

