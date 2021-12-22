﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestPostgres.Interfaces;
using TestPostgres.Models;

namespace TestPostgres.Controllers
{
    [Route("api/[controller]")]
    public class Manufacturer_DetailsController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public Manufacturer_DetailsController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public IEnumerable<Manufacturer_Details> Get()
        {
            return _dataAccessProvider.GetManufacturerDetailsRecords();
        }
        [HttpGet("{id}")]
        public Manufacturer_Details Get(int id)
        {
            return _dataAccessProvider.GetManufacturerDetailSingle(id);
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

