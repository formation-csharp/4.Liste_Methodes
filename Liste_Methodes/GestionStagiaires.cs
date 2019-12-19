using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste_Methodes
{
    public class GestionStagiaires
    {
        private List<Stagiaire> _ListStagiaire;
        private long Compteur;

        public GestionStagiaires()
        {
            this._ListStagiaire = new List<Stagiaire>();
            Compteur = 0;
        }

        public void Ajouter(Stagiaire s)
        {
            Compteur = Compteur + 1;
            s.Id = Compteur; // ++Compteur;
            this._ListStagiaire.Add(s);
        }
    }
}
