using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App1.Models
{
    public class Contacts
    {
        public int ID { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int address_number { get; set; }
        public string street_name { get; set; }
        public string street_type { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip_code { get; set; }
        public int phone_number { get; set; }
    }
}