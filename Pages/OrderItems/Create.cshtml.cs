using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FastCartMarketPlace.Data;
using FastCartMarketPlace.Models;

namespace FastCartMarketPlace.Pages_OrderItems
{
    public class CreateModel : PageModel
    {
        private readonly FastCartMarketPlace.Data.FastCartContext _context;

        public CreateModel(FastCartMarketPlace.Data.FastCartContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["OrderID"] = new SelectList(_context.Orders, "OrderID", "CustomerName");
        ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "Description");
            return Page();
        }

        [BindProperty]
        public OrderItem OrderItem { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OrderItems.Add(OrderItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
