using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPostgres.Models
{
    public class Genset_Relation
    {
        [Key]
        public string Genset_Sr_No { get; set; }
        public int Company_ID { get; set; }
        public int Distributer_ID { get; set; }
        public int Manufacturer_ID { get; set; }
        public string Genset_Part_No { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
    }
}
