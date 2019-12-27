using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste_Methodes
{
    /// <summary>
    /// CRUD - Create, Read, Update , Delete
    /// Ajouter, Afficher(), MiseAjour, Supprimer
    /// </summary>
    public class GestionStagiaires
    {

        // Liste des stagiaires doit être private
        private List<Stagiaire> _ListStagiaire;
        public static Int32 Compteur = 0;

        public GestionStagiaires()
        {
            this._ListStagiaire = new List<Stagiaire>();
          
        }

        public List<Stagiaire> Afficher()
        {
            return this._ListStagiaire;
        }

        /// <summary>
        /// Permet d'ajouter un stagiaire
        /// </summary>
        /// <param name="s">l'objet stagiaire à ajouter</param>
        public void Ajouter(Stagiaire s)
        {
            GestionStagiaires.Compteur = Compteur + 1;
            s.Id = Compteur; // ++Compteur;
            this._ListStagiaire.Add(s); 
        }

        public Stagiaire Rechercher_Par_Id(long id)
        {
            Stagiaire s = null;

            foreach (Stagiaire item in _ListStagiaire)
            {
                if (item.Id == id) s = item;
            }


            return s;
        }


        /// <summary>
        /// Solution 1
        /// </summary>
        /// <param name="id"></param>
        public void Supprimer_Par_Id(int id)
        {
            // Recherche dans la liste
            Stagiaire ValeurTrouve = null;
            for (int i = 0; i < _ListStagiaire.Count; i++)
            {
                if (_ListStagiaire[i].Id == id)
                {

                    ValeurTrouve = _ListStagiaire[i];
                }
            }


            // Supprimer
            _ListStagiaire.Remove(ValeurTrouve);
        }

        /// <summary>
        /// Solution 2
        /// </summary>
        /// <param name="id"></param>
        public void Supprimer2_Par_Id(long id)
        {
            // Recherche dans la liste
            Stagiaire ValeurTrouve = this.Rechercher_Par_Id(id);

            // Supprimer
            _ListStagiaire.Remove(ValeurTrouve);
        }

        //public void Supprimer3(int id)
        //{
        //    /// Linq
        //   var stg =  this._ListStagiaire
        //        .Where(s => s.Id == id)
        //        .FirstOrDefault();
        //    this._ListStagiaire.Remove(stg);


        //    this._ListStagiaire.Remove(this._ListStagiaire
        //        .Where(s => s.Id == id)
        //        .FirstOrDefault());

        //}

       

        public void Modifier(long Id, String Nom, String Prenom)
        {
            Stagiaire s = this.Rechercher_Par_Id(Id);
            s.Nom = Nom;
            s.Prenom = Prenom;

           // this._ListStagiaire[this._ListStagiaire.IndexOf(s)] = s;
        }


        public Stagiaire RechercherStagiaire(String Nom, String Prenom)
        {

            foreach (Stagiaire s in _ListStagiaire)
            {
                if (s.Nom == Nom && s.Prenom == Prenom)
                {
                    return s;
                }
            }
            return null;
        }

    }
}
