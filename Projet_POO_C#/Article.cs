using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO
{
    public class Article
    {
        protected string Marque { get; set; }
        protected string Nom { get; set; }
        protected int Prix { get; set; }

        public Article(string marque, string nom, int prix)
        {
            Marque = marque;
            Nom = nom;
            Prix = prix;
        }

    }
}
