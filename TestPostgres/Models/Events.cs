using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPostgres.Models
{
    public class Events
    {
        public string Genset_Sr_No { get; set; }
        public DateTime Timestamp { get; set; }
        public int Data_Packet { get; set; }
        public string Value { get; set; }
    }
}
