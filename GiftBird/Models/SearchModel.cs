using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GiftBird.Models
{
    public class SearchModel
    {   
        [Key]
        public string searchParams { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public int categoryOfCare { get; set; }
        //public List<bool> registry { get; set; }
    }


}