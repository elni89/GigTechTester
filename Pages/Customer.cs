using System;
using System.ComponentModel.DataAnnotations;

namespace GigTechTester.Pages
{
    public class Customer
    {
        [Key]
        public int customer_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string passwordHASH { get; set; }
        public string username { get; set; }
        public string profileImage { get; set; }
        public decimal vmoney { get; set; }
    }
}