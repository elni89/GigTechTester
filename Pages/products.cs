using System;
using System.ComponentModel.DataAnnotations;

namespace GigTechTester.Pages
{
    public class Product
    {
        [Key]
        public int product_id { get; set; } // Update 'Id' to 'CustomerId'
        public string category { get; set; } // Update 'LastName' to 'Last_name'
        public string title { get; set; } // Update 'LastName' to 'Last_name'
    }
}