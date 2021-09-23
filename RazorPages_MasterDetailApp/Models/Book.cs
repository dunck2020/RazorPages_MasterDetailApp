using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages_MasterDetailApp.Models
{
    public class Book
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public List<String> Genres { get; set; }

        public int PageCount { get; set; }

        public int PubYear { get; set; }

        public string Description { get; set; }

        public List<Review> Reviews { get; set; }

        public double AvgRating
        {
            get 
            { 
                return UpdateRating(); 
            }
        }

        public double UpdateRating()
        {
            double average = 0;

            if (Reviews.Count != 0)
            {
                double sum = 0;
                foreach (var r in Reviews)
                {
                    sum += r.Rating;
                }
                average = sum / Reviews.Count;
            }

            return average;
        }
    }
}
