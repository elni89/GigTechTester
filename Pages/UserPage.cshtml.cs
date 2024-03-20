// Importing necessary namespaces
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GigTechTester.Pages
{
    // Declaring the UserPage class that inherits from PageModel
    public class UserPage : PageModel
    {
        private readonly ApplicationDbContext _context;

 
    // Constructor for UserPage that takes an instance of ApplicationDbContext as a parameter
    public UserPage(ApplicationDbContext context)
        {
            _context = context;
        }

        // Property to hold a list of Customer objects
        public IList<Customer> Customers { get; set; }

        // Method that runs when the page is accessed
        public void OnGet()
        {
            // Fetch all customers from the database and assign them to the Customers property
            Customers = _context.Customers.ToList();
        }
    }