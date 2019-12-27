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
            Console.WriteLine(GestionStagiaires.Compteur);

            // Création des classes Gestion
            GestionStagiaires gs = new GestionStagiaires();
            GestionStagiaires gs2 = new GestionStagiaires();
            // Création d'une instance de la classe 
            Stagiaire s = new Stagiaire();
            s.Nom = "Madani";
            s.DateNaissance = new DateTime(2001, 2, 3);


            // Saisie d'un stagiaire
            Stagiaire s2 = Lire();

            // Test de la méthode Ajouter
            gs.Ajouter(s);
            gs2.Ajouter(s2);

            // Supprimer
            gs.Supprimer2_Par_Id(s2.Id);

            // Modifier
            gs.Modifier(s.Id, "Chami", "Mouad");
    
            foreach (Stagiaire item in gs.Afficher())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(GestionStagiaires.Compteur);
            Console.ReadKey();
        }

        public static  Stagiaire Lire()
        {
            Stagiaire s = new Stagiaire();

            Console.WriteLine("Lecture du Stagiaire ");
            Console.Write("Nom : ");
            s.Nom = Console.ReadLine();
            Console.Write("Prénom : ");
            s.Prenom = Console.ReadLine();

            return s;
        }
    }
}
