using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_C_
{
    public class Ordinateur
    {
        public string Composants { get; set; }
        public string Accessoires { get; set; }
        public string TypeUtilisation { get; set; }

        public Ordinateur(string compostants, string accessoires, string typeUtilisation)
        {
            Composants = compostants;
            Accessoires = accessoires;
            TypeUtilisation = typeUtilisation;
        }
    }

}
