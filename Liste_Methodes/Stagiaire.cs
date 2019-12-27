using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste_Methodes
{
    public class Stagiaire
    {
        public long Id { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public DateTime DateNaissance { get; set; }


        public override string ToString()
        {
            return $"Stagiaire : {this.Nom}, {this.Prenom}";
        }
    }
}
