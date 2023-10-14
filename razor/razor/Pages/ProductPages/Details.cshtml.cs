using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor.Models;

namespace razor.Pages.ProductPages
{
    public class DetailsModel : PageModel
    {
        #region connect to database

        private readonly razor.Models.Context _context;

        public DetailsModel(razor.Models.Context context)
        {
            _context = context;
        }
        #endregion

        #region on get

        public Product Product { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                Product = product;
            }
            return Page();
        }
        #endregion
    }
}
