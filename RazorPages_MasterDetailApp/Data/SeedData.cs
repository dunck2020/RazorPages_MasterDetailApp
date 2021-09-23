using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPages_MasterDetailApp.Models;

namespace RazorPages_MasterDetailApp.Data
{
    public class SeedData
    {
        public static List<Book> Initialize()
        {

            List<Book> bookList = new List<Book>(){
            new Book()
            {
                ID = 1000,
                Title = "The Galaxy, and The Ground Within",
                Author = "Becky Chambers",
                Genres = new List<string> { "Science Fiction" },
                PageCount = 325,
                PubYear = 2021,
                Description = "Return to the sprawling, Hugo Award-winning universe of the Galactic Commons to explore" +
                            "another corner of the cosmos - one often mentioned, but not yet explored - in this absorbing" +
                            "entry in the Wayfarers series, which blends heart warming characters and imaginative adventure.",
                Reviews = new List<Review>
                    {
                        new Review()
                        {
                            ReviewId = 1001,
                            Rating = 3,
                            Comment = "blah,blah,blah",
                            UserName = "JSquared"
                        },
                        new Review()
                        {
                            ReviewId = 1002,
                            Rating = 1,
                            Comment = "good, bad, ugly",
                            UserName = "Tom Smith"
                        },
                        new Review()
                        {
                            ReviewId = 1003,
                            Rating = 2,
                            Comment = "no plot development",
                            UserName = "Fred"
                        }
                    },
            },
            new Book()
            {
                ID = 2000,
                Title = "Into The Wild",
                Author = "Jon Krakauer",
                Genres = new List<string> { "Drama" },
                PageCount = 207,
                PubYear = 1996,
                Description = "In April 1992 a young man from a well-to-do family hitchhiked to Alaska and walked alone" +
                              "into the wilderness north of Mt.McKinley.  His name was Christopher Johnson McCandlesss.  He" +
                              "had given $25,000 in savings to charity, abandoned his car and most of his possesions, burned" +
                              "all the cash in his wallet, and invented a new life for himself.  Four months later, his decomposed" +
                              "body was found by a moose hunter...",
                Reviews = new List<Review>
                    {
                        new Review()
                        {
                            ReviewId = 2001,
                            Rating = 5,
                            Comment = "Amazing journey into a young man's mind",
                            UserName = "JSquared"
                        },
                        new Review()
                        {
                            ReviewId = 2002,
                            Rating = 4,
                            Comment = "short but I could not put it down",
                            UserName = "Tom Smith"
                        },
                        new Review()
                        {
                            ReviewId = 2003,
                            Rating = 5,
                            Comment = "Unbelievable trip across the country through the eyes of a troubled youth.",
                            UserName = "Fred"
                        }
                    },
            },
            new Book()
            {
                ID = 3000,
                Title = "The Alchemist",
                Author = "Paulo Coelho",
                Genres = new List<string> { "Drama", "Fantasy", "Adventure" },
                PageCount = 192,
                PubYear = 1988,
                Description = "This story, dazzling in its powerful simplicity and inspiring wisdom, is about an Analusian" +
                              "shepherd boy name Santiago who travels from his homeland Spain to the Eqyptian desert in search" +
                              "of treasure buried by the Pyramids.",
                Reviews = new List<Review>
                    {
                        new Review()
                        {
                            ReviewId = 3001,
                            Rating = 4,
                            Comment = "This Brazilian wizard akes books disappear from stores.",
                            UserName = "New York Times"
                        },
                        new Review()
                        {
                            ReviewId = 3002,
                            Rating = 4,
                            Comment = "Coelho's books have had a life-enchanting effect on millions of people.",
                            UserName = "San Francisco Chronicle"
                        },
                        new Review()
                        {
                            ReviewId = 3003,
                            Rating = 5,
                            Comment = "Beneath the novel's compelling story abd the shimmering elegance with which it's told lies a bedrock of wisdom about following one's heart",
                            UserName = "Booklist"
                        }
                    },
            } }; 
            return bookList;
        }
    }
}

