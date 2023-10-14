using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor.Models;

namespace razor.Pages.ProductPages
{
    public class IndexModel : PageModel
    {
        #region connect to database

        private readonly razor.Models.Context _context;

        public IndexModel(razor.Models.Context context)
        {
            _context = context;
        }
        #endregion

        #region on get to list
        public IList<Product> Product { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
        #endregion
    }
}
