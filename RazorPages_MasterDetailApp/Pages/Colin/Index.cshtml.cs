using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPages_MasterDetailApp.Data;
using RazorPages_MasterDetailApp.Models;

namespace RazorPages_MasterDetailApp.Pages.Colin
{
    public class IndexModel : PageModel
    {
        private readonly RazorPages_MasterDetailApp.Data.RazorPages_MasterDetailAppContext _context;

        public IndexModel(RazorPages_MasterDetailApp.Data.RazorPages_MasterDetailAppContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        [BindProperty(SupportsGet = true)]
        public string TitleSearch { get; set; }

        [BindProperty(SupportsGet = true)]
        public string AuthorSearch { get; set; }

        [BindProperty(SupportsGet = true)]
        public string GenreSearch { get; set; }

        public string TypeOfSort { get; set; }

        public async Task OnGetAsync(string sortType)
        {
            var books = from b in _context.Book
                        select b;

            TypeOfSort = sortType;

            if (!string.IsNullOrEmpty(TitleSearch))
            {
                books = books.Where(s => s.Title.Contains(TitleSearch));
            }
            if (!string.IsNullOrEmpty(AuthorSearch))
            {
                books = books.Where(s => s.Author.Contains(AuthorSearch));
            }
            if (!string.IsNullOrEmpty(GenreSearch))
            {
                books = books.Where(s => s.Genres.Contains(GenreSearch));
            }

            if (!string.IsNullOrEmpty(TypeOfSort))
            {
                if (TypeOfSort == "title")
                {
                    books = books.OrderBy(b => b.Title);
                }
                if (TypeOfSort == "pubyear")
                {
                    books = books.OrderBy(b => b.PubYear);
                }
                if (TypeOfSort == "pagecount")
                {
                    books = books.OrderBy(b => b.PageCount);
                }
            }

            Book = await books.ToListAsync();
        }
    }
}
