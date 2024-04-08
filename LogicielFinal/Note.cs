using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicielFinal
{
    public class Note
    {
        public int NumeroEtudiant { get; set; }
        public int NumeroCours { get; set; }
        public float Notes { get; set; }

        // Constructeur optionnel pour initialiser une nouvelle instance de Note
        public Note(int numeroEtudiant, int numeroCours, float note)
        {
            NumeroEtudiant = numeroEtudiant;
            NumeroCours = numeroCours;
            Notes = note;
        }

        // Vous pourriez vouloir surcharger la méthode ToString() pour faciliter l'affichage
        public override string ToString()
        {
            return $"Etudiant #{NumeroEtudiant} - Cours #{NumeroCours} - Note: {Notes}";
        }
        public string DisplayText
        {
            get { return $"Etudiant {NumeroEtudiant} - Cours {NumeroCours} : Note {Notes}"; }
        }
    }

}
