using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GiftBird.Models
{
    public class LoginModels
    {
        [Key]
        public string uName { get; set; }
        public string password { get; set; }
    }
}