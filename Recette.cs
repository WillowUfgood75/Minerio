using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_Factorio
{
    internal class Recette
    {
        private Ressource produitBrut;
        private Ressource produitTransformee;
        public Recette(Ressource produitBrut, Ressource produitTransformee)
        {
            this.produitBrut = produitBrut;
            this.produitTransformee = produitTransformee;
        }
    }
}
