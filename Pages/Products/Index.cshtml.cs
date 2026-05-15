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

        public string CurrentFilter { get; set; } = "";
        public string CurrentSort { get; set; } = "";
        public string NameSort { get; set; } = "";
        public string PriceSort { get; set; } = "";

        public int PageIndex { get; set; }
        public int TotalPages { get; set; }

        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotalPages;

        public async Task OnGetAsync(string searchString, string sortOrder, int pageIndex = 1)
        {
            const int pageSize = 10;

            CurrentFilter = searchString;
            CurrentSort = sortOrder;

            NameSort = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            PriceSort = sortOrder == "price_asc" ? "price_desc" : "price_asc";

            IQueryable<Product> productsQuery = _context.Products
                .Include(p => p.Reviews);

            if (!string.IsNullOrEmpty(searchString))
            {
                productsQuery = productsQuery.Where(p =>
                    p.Name.Contains(searchString) ||
                    p.Category.Contains(searchString) ||
                    p.Description.Contains(searchString));
            }

            productsQuery = sortOrder switch
            {
                "name_desc" => productsQuery.OrderByDescending(p => p.Name),
                "price_asc" => productsQuery.OrderBy(p => p.Price),
                "price_desc" => productsQuery.OrderByDescending(p => p.Price),
                _ => productsQuery.OrderBy(p => p.Name),
            };

            var count = await productsQuery.CountAsync();
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            PageIndex = pageIndex;

            Product = await productsQuery
                .Skip((PageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }
    }
}