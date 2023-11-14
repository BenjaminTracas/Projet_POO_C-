using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO
{
    public class Vetement : Article
    {
        protected string Taille { get; set; }
        protected string Couleur { get; set; }
        protected string Matiere { get; set; }

        public Vetement(string marque, string nom, int prix, string taille, string couleur, string matiere)
            : base(marque, nom, prix)
        {
            Taille = taille;
            Couleur = couleur;
            Matiere = matiere;
        }

    }
}
