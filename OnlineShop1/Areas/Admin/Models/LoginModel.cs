using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop1.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Moi nhap User name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Moi nhap Password")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}