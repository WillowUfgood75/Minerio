using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_Factorio
{
    internal class Usine
    {
        private string nom;
        private Recette recette;
        public Usine(string nom, Recette recette)
        {
            this.nom = nom;
            this.recette = recette;
        }
    }
}
