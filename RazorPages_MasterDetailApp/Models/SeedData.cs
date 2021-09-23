using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPages_MasterDetailApp.Data;
using System;
using System.Linq;

namespace RazorPages_MasterDetailApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPages_MasterDetailAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPages_MasterDetailAppContext>>()))
            {
                // Look for any books.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book()
                    {
                        Title = "The Galaxy, and The Ground Within",
                        Author = "Becky Chambers",
                        Genres = "Science Fiction",
                        PageCount = 325,
                        PubYear = 2021,
                        Description =   "Return to the sprawling, Hugo Award-winning universe of the Galactic Commons to explore " +
                                        "another corner of the cosmos - one often mentioned, but not yet explored - in this absorbing " +
                                        "entry in the Wayfarers series, which blends heart warming characters and imaginative adventure.",
                        Review =    "What can I say about Becky Chambers that I haven't already said a thousand times before? " +
                                    "I just absolutely adore the Wayfarers series and this book was no exception"
                    },
                    new Book()
                    {
                        Title = "Into The Wild",
                        Author = "Jon Krakauer",
                        Genres = "Drama",
                        PageCount = 207,
                        PubYear = 1996,
                        Description = "In April 1992 a young man from a well-to-do family hitchhiked to Alaska and walked alone " +
                                      "into the wilderness north of Mt.McKinley.  His name was Christopher Johnson McCandlesss.  He " +
                                      "had given $25,000 in savings to charity, abandoned his car and most of his possesions, burned " +
                                      "all the cash in his wallet, and invented a new life for himself.  Four months later, his decomposed " +
                                      "body was found by a moose hunter...",
                        Review =    "This was my first Jon Krakauer book, and I was impressed with the story and many related stories he told " +
                                    "including the one about the author himself. By now you have probably read the book, if not please do!"
                    },
                    new Book()
                    {
                        Title = "The Alchemist",
                        Author = "Paulo Coelho",
                        Genres = "Adventure",
                        PageCount = 192,
                        PubYear = 1988,
                        Description = "This story, dazzling in its powerful simplicity and inspiring wisdom, is about an Analusian " +
                                      "shepherd boy name Santiago who travels from his homeland Spain to the Eqyptian desert in search " +
                                      "of treasure buried by the Pyramids.",
                        Review = "Coelho's books have had a life-enchanting effect on millions of people."
                    });
                context.SaveChanges();
            }
        }
    }
}
