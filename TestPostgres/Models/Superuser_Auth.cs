using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPostgres.Models
{
    public class Superuser_Auth
    {

        public string Superuser_email { get; set; }
        public string Superuser_pass { get; set; }
        public string Superuser_name { get; set; }
        [Key]
        public int Superuser_ID { get; set; }
    }
}
