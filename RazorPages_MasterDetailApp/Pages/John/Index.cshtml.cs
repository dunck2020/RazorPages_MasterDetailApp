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

namespace RazorPages_MasterDetailApp.Pages.John
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
        public string BookGenres { get; set; }
        public SelectList Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string BookAuthors { get; set; }
        public SelectList Authors { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public string TitleSort { get; set; }



        public async Task OnGetAsync(string filterOrder)
        {
            TitleSort = filterOrder;

            IQueryable<string> genreQuery = from m in _context.Book orderby m.Genres select m.Genres;
            IQueryable<string> authorQuery = from m in _context.Book orderby m.Author select m.Author;

            var books = from m in _context.Book select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                books = books.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(BookGenres))
            {
                books = books.Where(x => x.Genres == BookGenres);
            }

            if (!string.IsNullOrEmpty(BookAuthors))
            {
                books = books.Where(x => x.Author == BookAuthors);
            }

            if (TitleSort == "desc")
            {
                books = books.OrderByDescending(m => m.Title);
            }
            else
            {
                books = books.OrderBy(m => m.Title);
            }


            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            
            Authors = new SelectList(await authorQuery.Distinct().ToListAsync());

            Book = await books.AsNoTracking().ToListAsync();
        }
    }
}
