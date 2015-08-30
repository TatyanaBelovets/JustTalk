using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SocialNetwork1._1.Models
{
    public class User
    {
        [Key, Required, RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Incorrect e-mail!")]
        public string Login { get; set; }   
        [Required, RegularExpression(@"\S{8,20}")]
        public string Password{ get; set; }
    }

    public class Admin : User
    {
        
    }
}