using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPostgres.Models
{
    public class Distributer_Auth
    {

        public string Distributer_email { get; set; }
        public string Distributer_pass { get; set; }
        public string Distributer_name { get; set; }
        [Key]
        public int Distributer_User_ID { get; set; }
        public int Distributer_ID { get; set; }
    }
}
