using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages_MasterDetailApp.Data;
using RazorPages_MasterDetailApp.Models;

namespace RazorPages_MasterDetailApp.Pages.Sammi
{
    public class IndexModel : PageModel
    {
        private readonly RazorPages_MasterDetailApp.Data.RazorPages_MasterDetailAppContext _context;

        public IndexModel(RazorPages_MasterDetailApp.Data.RazorPages_MasterDetailAppContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
