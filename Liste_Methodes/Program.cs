using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste_Methodes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création des classes Gestion
            GestionStagiaires gestionStagiaires =
                new GestionStagiaires();

            Stagiaire s = new Stagiaire();
            s.Nom = "Madani";
            s.DateNaissance = new DateTime(2001, 2, 3);

            gestionStagiaires.Ajouter(s);

            Stagiaire s2 = new Stagiaire();
            s2.Nom = "Chami";
            s2.DateNaissance = new DateTime(2001, 2, 3);

            gestionStagiaires.Ajouter(s2);

        }
    }
}
