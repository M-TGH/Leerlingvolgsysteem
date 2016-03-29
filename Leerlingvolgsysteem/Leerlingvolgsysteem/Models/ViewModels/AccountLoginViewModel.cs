using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Leerlingvolgsysteem.Models.ViewModels
{
    //<Author> Tim Prosé </Author>
    //Login page Object
    public class AccountLoginViewModel
    {
        public int userId { get; set; }

        [Required(ErrorMessage = "Fill in an Username!")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Fill in a Password!")]
        public string password { get; set; }

        public int AuthId { get; set; }
        public string Message { get; set; }
        public Boolean Error { get; set; }
    }
}