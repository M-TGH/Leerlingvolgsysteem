using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Leerlingvolgsysteem.Models
{
    public class AccountViewModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string lastName_prefix { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public int homeNr { get; set; }
        public string home_prefix { get; set; }
        public string place { get; set; }
        public string email { get; set; }
        public string phoneNr { get; set; }
        public System.DateTime dateOfBirth { get; set; }
        public string password { get; set; }
        public string userName { get; set; }
    }
}