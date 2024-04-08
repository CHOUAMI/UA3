using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicielFinal
{
    public class Cours
    {
        public int NumeroCours { get; set; }
        public string Code { get; set; }
        public string Titre { get; set; }

        // Constructeur sans paramètre
        public Cours()
        {
        }

        // Constructeur avec paramètres
        public Cours(int numeroCours, string code, string titre)
        {
            NumeroCours = numeroCours;
            Code = code;
            Titre = titre;
        }

        // Méthode pour représenter l'objet Cours sous forme de chaîne de caractères
        public override string ToString()
        {
            return $"{Code} - {Titre}";
        }
    }

}
