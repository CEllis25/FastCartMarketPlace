using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FastCartMarketPlace.Data;
using FastCartMarketPlace.Models;

namespace FastCartMarketPlace.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly FastCartContext _context;

        public IndexModel(FastCartContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products
                .Include(p => p.Reviews)
                .ToListAsync();
        }
    }
}