using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicielFinal
{
    public class Etudiant
    {
        public int NumeroEtudiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        // Constructeur sans paramètre
        public Etudiant()
        {
        }

        // Constructeur avec paramètres
        public Etudiant(int numero, string nom, string prenom)
        {
            NumeroEtudiant = numero;
            Nom = nom;
            Prenom = prenom;
        }
        public string NomComplet
        {
            get { return $"{Nom} {Prenom}"; }
        }

        // Vous pouvez ajouter d'autres méthodes et propriétés selon les besoins, comme par exemple une méthode pour afficher les informations de l'étudiant
        public override string ToString()
        {
            return $"{NumeroEtudiant}: {Nom} {Prenom}";
        }
    }

}
