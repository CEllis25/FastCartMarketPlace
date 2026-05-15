using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FastCartMarketPlace.Data;
using FastCartMarketPlace.Models;

namespace FastCartMarketPlace.Pages_Reviews
{
    public class DetailsModel : PageModel
    {
        private readonly FastCartMarketPlace.Data.FastCartContext _context;

        public DetailsModel(FastCartMarketPlace.Data.FastCartContext context)
        {
            _context = context;
        }

        public Review Review { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews.FirstOrDefaultAsync(m => m.ReviewID == id);

            if (review is not null)
            {
                Review = review;

                return Page();
            }

            return NotFound();
        }
    }
}
