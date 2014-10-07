using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVC2.Models
{
    public class Reponse
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string telephone { get; set; }
        public bool? presence { get; set; }
    }
}