//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Leerlingvolgsysteem.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
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
