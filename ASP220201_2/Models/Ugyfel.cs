using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP220201_2.Models
{
    public class Ugyfel
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public DateTime Szuletett { get; set; }
        public bool Nagykoru => 
            (DateTime.Now - Szuletett).TotalDays / 365F >= 18;
    }
}