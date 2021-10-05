using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPages_MasterDetailApp.Models;
using System.ComponentModel.DataAnnotations;


namespace RazorPages_MasterDetailApp.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Titles can be up to 100 characters long.")]
        public string Title { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Authors can be up to 30 characters long.")]
        public string Author { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Genres can be up to 25 characters long.")]
        public string Genres { get; set; }

        [Required]
        [Range(0, 5000, ErrorMessage ="Page counts should be from 0 to 5000.")]
        public int PageCount { get; set; }

        [Required]
        [Range(0, 2022, ErrorMessage = "Publication year should be from 0 to 2022.")]
        public int PubYear { get; set; }

        [Required]
        [StringLength(2000, ErrorMessage = "Book descriptions can be up to 2000 characters long.")]
        public string Description { get; set; }

        [Required]
        [StringLength(2000, ErrorMessage = "Reviews can be up to 2000 characters long.")]
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
