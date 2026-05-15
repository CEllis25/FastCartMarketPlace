using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FastCartMarketPlace.Data;
using FastCartMarketPlace.Models;

namespace FastCartMarketPlace.Pages_OrderItems
{
    public class DetailsModel : PageModel
    {
        private readonly FastCartMarketPlace.Data.FastCartContext _context;

        public DetailsModel(FastCartMarketPlace.Data.FastCartContext context)
        {
            _context = context;
        }

        public OrderItem OrderItem { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderitem = await _context.OrderItems.FirstOrDefaultAsync(m => m.OrderItemID == id);

            if (orderitem is not null)
            {
                OrderItem = orderitem;

                return Page();
            }

            return NotFound();
        }
    }
}
