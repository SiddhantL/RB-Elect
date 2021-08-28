using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPostgres.Models
{
    public class Manufacturer_Auth
    {

        public string Manufacturer_email { get; set; }
        public string Manufacturer_pass { get; set; }
        public string Manufacturer_name { get; set; }
        [Key]
        public int Manufacturer_User_ID { get; set; }
        public int Manufacturer_ID { get; set; }
    }
}
