using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages_MasterDetailApp.Models
{
    public class Review
    {
        //Model for instantiating user comments
        public int ReviewId;
        public string UserName;
        public string Comment;
        public int Rating;
    }
}
