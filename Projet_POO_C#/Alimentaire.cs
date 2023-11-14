using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_C_
{
    public class Alimentaire
    {
        public string Ingredients { get; set; }
        public string NutriScore { get; set; }
        public int Poids { get; set; }

        public void Toto(string ingredients, string nutriScore, int poids)
        {
            Ingredients = ingredients;
            NutriScore = nutriScore;
            Poids = poids;
        }
    }
}
