using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPages_MasterDetailApp.Models;


namespace RazorPages_MasterDetailApp.Models
{
    public class Book
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Genres { get; set; }

        public int PageCount { get; set; }

        public int PubYear { get; set; }

        public string Description { get; set; }

        public string Review { get; set; }

        // First we will get the app working correctly then we can add review class

        //    public List<Review> ReviewID { get; set; }

        //    public double AvgRating
        //    {
        //        get
        //        {
        //            return UpdateRating();
        //        }
        //    }

        //    public double UpdateRating()
        //    {
        //        double average = 0;

        //        if (ReviewID.Count != 0)
        //        {
        //            double sum = 0;
        //            foreach (var r in ReviewID)
        //            {
        //                sum += r.Rating;
        //            }
        //            average = sum / ReviewID.Count;
        //        }

        //        return average;
        //    }
        //
    }
}
