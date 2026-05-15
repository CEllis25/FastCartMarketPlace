using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FastCartMarketPlace.Data;
using FastCartMarketPlace.Models;

namespace FastCartMarketPlace.Pages_Orders
{
    public class IndexModel : PageModel
    {
        private readonly FastCartMarketPlace.Data.FastCartContext _context;

        public IndexModel(FastCartMarketPlace.Data.FastCartContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Order = await _context.Orders.ToListAsync();
        }
    }
}
