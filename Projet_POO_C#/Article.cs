using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_C_
{
    public class Article
    {
        public string Marque { get; set; }
        public string Nom { get; set; }
        public string Prix { get; set; }
        public Ordinateur ordinateur { get; set; }
        public Vetement vetement { get; set; }
        public Alimentaire alimentaire { get; set; }



        public Article(string marque, string nom, string prix, Ordinateur ordinateur)
        {
            Marque = marque;
            Nom = nom;
            Prix = prix;
        }

    }
}
