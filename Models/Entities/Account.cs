using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WinFormsCore.Models.Entities;

public partial class Account
{
        [Key]   
        public int ID_Acc { get; set; }
        public string Username { get; set; }
        public string Pword { get; set; }
        public string Fullname { get; set; }
        public string AccountRole { get; set; }
}

