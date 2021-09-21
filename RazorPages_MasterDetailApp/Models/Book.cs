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

        public string PubDate { get; set; }

        public string Description { get; set; }

        public List<Review> Reviews { get; set; }

        public float AvgRating { get; set; }

        public float UpdateRating()
        {
            int average = 0;
            // Test comment to fix branches
            return average;
        }
    }
}
