using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPostgres.Models
{
    public class Manufacturer_Details
    {

        public string Manufacturer_Name { get; set; }
        [Key]
        public string Manufacturer_ID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Locality { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pin { get; set; }
        public string Contact_Person { get; set; }
        public Int64 Contact_Mobile { get; set; }
        public string Contact_Email { get; set; }
        public DateTime Created_On { get; set; }
        public DateTime Modified_On { get; set; }
    }
}
