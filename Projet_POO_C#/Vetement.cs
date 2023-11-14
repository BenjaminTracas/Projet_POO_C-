using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_C_
{
    public class Vetement
    {
        public string Taille { get; set; }
        public string Couleur { get; set; }
        public string Matiere { get; set; }

        public Vetement(string taille, string couleur, string matiere)
        {
            Taille = taille;
            Couleur = couleur;
            Matiere = matiere;
        }

    }
}
