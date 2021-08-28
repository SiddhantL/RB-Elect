using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPostgres.Models
{
    public class Events
    {
        [Key]
        public int Superuser_ID { get; set; }

        public string Event_name { get; set; }
        public int Event_ID { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
