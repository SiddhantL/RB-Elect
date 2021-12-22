using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPostgres.Models
{
    public class User_Auth
    {

        public string User_email { get; set; }
        public string User_pass { get; set; }
        public string User_name { get; set; }
        [Key]
        public int User_ID { get; set; }
        public int Company_ID { get; set; }
    }


}
