using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GigTechTester.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customers { get; set; }
        public IList<Product> Products { get; set; }

        public Product SpecifiedProduct { get; set; }

        public IList<Customer> CustomersStartingWithN { get; set; }

        public void OnGet()
        {
            Customers = _context.Customers.ToList();
            Products = _context.Products.ToList();
            SpecifiedProduct = _context.Products.FirstOrDefault(p => p.product_id == 1);
            CustomersStartingWithN = _context.Customers
                .Where(c => c.first_name != null && EF.Functions.Like(c.first_name, "N%"))
                .ToList();
        }
    }
}