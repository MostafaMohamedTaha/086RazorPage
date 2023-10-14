using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor.Models;

namespace razor.Pages.ProductPages
{
    public class CreateModel : PageModel
    {
        #region connect to database

        private readonly razor.Models.Context _context;

        public CreateModel(razor.Models.Context context)
        {
            _context = context;
        }
        #endregion

        #region on get

        public IActionResult OnGet()
        {
            return Page();
        }
        #endregion

        #region post
        [TempData]
        public string Message { get; set; }
        [BindProperty]
        public Product Product { get; set; } = default!;
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Products == null || Product == null)
            {
                return Page();
            }

            _context.Products.Add(Product);
            await _context.SaveChangesAsync();
            Message = $"Product {Product.ProductName} added";

            return RedirectToPage("./Index");
        }
        #endregion
    }
}
