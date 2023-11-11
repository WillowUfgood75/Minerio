using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_Factorio
{
    internal class Ressource
    {
        private string nom;
        private int valeur;
        public Ressource(string nom, int valeur)
        {
            this.nom = nom;
            this.valeur = valeur;
        }
        public string Nom { get { return nom; } }
        public int Valeur { get { return valeur; } }
    }
}
