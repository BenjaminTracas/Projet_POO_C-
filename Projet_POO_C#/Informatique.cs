using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO
{
    public class Ordinateur : Article
    {
        protected string Composants { get; set; }
        protected string Accessoires { get; set; }
        protected string TypeUtilisation { get; set; }

        public Ordinateur(string marque, string nom, int prix, string composants, string accessoires, string typeUtilisation)
            : base(marque, nom, prix)
        {
            Composants = composants;
            Accessoires = accessoires;
            TypeUtilisation = typeUtilisation;
        }
    }

}
