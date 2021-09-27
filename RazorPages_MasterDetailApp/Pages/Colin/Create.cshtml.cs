using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPages_MasterDetailApp.Data;
using RazorPages_MasterDetailApp.Models;

namespace RazorPages_MasterDetailApp.Pages.Colin
{
    public class CreateModel : PageModel
    {
        private readonly RazorPages_MasterDetailApp.Data.RazorPages_MasterDetailAppContext _context;

        public CreateModel(RazorPages_MasterDetailApp.Data.RazorPages_MasterDetailAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
