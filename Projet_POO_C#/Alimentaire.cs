using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO
{
    public class Alimentaire : Article
    {
        protected string Ingredients { get; set; }
        protected string NutriScore { get; set; }
        protected string Poids { get; set; }

        public Alimentaire(string marque, string nom, int prix, string ingredients, string nutriScore, string poids)
            : base(marque, nom, prix)

        {
            Ingredients = ingredients;
            NutriScore = nutriScore;
            Poids = poids;
        }
    }
}
