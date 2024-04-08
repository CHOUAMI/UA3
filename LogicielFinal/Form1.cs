using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicielFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RemplirComboBoxEtudiants();
            RemplirComboBoxCours();
        }

        private void Prenom_Click(object sender, EventArgs e)
        {

        }
        private List<Etudiant> listeEtudiants = new List<Etudiant>();
        private void button1_Click(object sender, EventArgs e)
        {


            // Remplacez les noms des contrôles par les noms corrects définis dans votre formulaire.
            string numeroEtudiant = txtNumeroEtudiant.Text; // Assurez-vous que 'txtNumeroEtudiant' est le bon nom de votre TextBox
            string nomEtudiant = txtNom.Text;              // Assurez-vous que 'txtNom' est le bon nom de votre TextBox
            string prenomEtudiant = txtPrenom.Text;        // Assurez-vous que 'txtPrenom' est le bon nom de votre TextBox

            // Vérifiez que les champs ne sont pas vides.
            if (string.IsNullOrWhiteSpace(numeroEtudiant) ||
                string.IsNullOrWhiteSpace(nomEtudiant) ||
                string.IsNullOrWhiteSpace(prenomEtudiant))
            {
                MessageBox.Show("Tous les champs doivent être remplis.");
                return;
            }

            // Créez une instance de l'objet Etudiant.
            Etudiant nouvelEtudiant = new Etudiant
            {
                NumeroEtudiant = int.Parse(numeroEtudiant), // Assurez-vous que le numéro peut être converti en int
                Nom = nomEtudiant,
                Prenom = prenomEtudiant
            };
            listeEtudiants.Add(nouvelEtudiant);

            // Chemin d'accès au fichier où vous voulez enregistrer les informations de l'étudiant.
            string path = @"C:\Users\amira\OneDrive\Bureau\Dossier etudiant\Etudiant.txt";

            // Écrivez les informations dans le fichier.
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true)) // 'true' pour ajouter au fichier existant
                {
                    sw.WriteLine($"{nouvelEtudiant.NumeroEtudiant};{nouvelEtudiant.Nom};{nouvelEtudiant.Prenom}");
                }

                MessageBox.Show("Étudiant créé avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'écriture dans le fichier : {ex.Message}");
            }



            //button1.Click += new EventHandler(button1_Click);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            /* listEtudiants.Items.Clear();
             foreach (Etudiant etudiant in listeEtudiants)
             {
                 listEtudiants.Items.Add(etudiant.ToString());
             }*/

            string path = @"C:\Users\amira\OneDrive\Bureau\Dossier etudiant\Etudiant.txt"; // Remplacez avec le chemin réel du fichier

            try
            {
                string[] lines = File.ReadAllLines(path);
                List<Etudiant> etudiants = new List<Etudiant>();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length >= 3)
                    {
                        if (int.TryParse(parts[0], out int numero))
                        {
                            Etudiant etudiant = new Etudiant
                            {
                                NumeroEtudiant = numero,
                                Nom = parts[1],
                                Prenom = parts[2]
                            };
                            etudiants.Add(etudiant);
                        }
                        else
                        {
                            MessageBox.Show("Une ligne dans le fichier ne contient pas un numéro d'étudiant valide.");
                        }
                    }
                }

                listEtudiants.Items.Clear();
                foreach (Etudiant etudiant in etudiants)
                {
                    listEtudiants.Items.Add(etudiant.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des étudiants : {ex.Message}");
            }
        }
        private List<Cours> listeDesCours = new List<Cours>();

        public object Titre { get; private set; }
        public object Code { get; private set; }
        public object NumeroCours { get; private set; }

        private void button2_Click(object sender, EventArgs e)
        {

            // Vérifiez que les champs de saisie ne sont pas vides (à faire pour chaque TextBox)
            if (string.IsNullOrWhiteSpace(txtNumeroCours.Text) || string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtTitre.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs du cours.");
                return;
            }

            try
            {
                int numeroCours = int.Parse(txtNumeroCours.Text);
                string code = txtCode.Text;
                string titre = txtTitre.Text;

                Cours nouveauCours = new Cours(numeroCours, code, titre);

                // Ajouter le nouveau cours à la liste des cours
                listeDesCours.Add(nouveauCours);

                // Ajouter le cours à la ListBox pour l'affichage
                listCours.Items.Add(nouveauCours.ToString());

                // Optionnel : Vider les champs après l'ajout
                txtNumeroCours.Clear();
                txtCode.Clear();
                txtTitre.Clear();

                string pathCours = @"C:\Users\amira\OneDrive\Bureau\Dossier etudiant\Cours.txt"; // Modifiez avec le chemin réel du fichier

                // Écrivez les informations dans le fichier.
                using (StreamWriter sw = new StreamWriter(pathCours, true)) // 'true' pour ajouter au fichier existant
                {
                    sw.WriteLine($"{nouveauCours.NumeroCours};{nouveauCours.Code};{nouveauCours.Titre}");
                }

                MessageBox.Show("Cours ajouté avec succès !");
            }
            catch (FormatException)
            {
                MessageBox.Show("Le numéro du cours doit être un nombre entier.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du cours : {ex.Message}");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (listCours.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un cours à supprimer.");
                return;
            }

            try
            {
                // Trouver le cours correspondant dans la liste des cours
                string selectedCours = listCours.SelectedItem.ToString();
                var coursASupprimer = listeDesCours.FirstOrDefault(c => c.ToString() == selectedCours);

                if (coursASupprimer != null)
                {
                    // Supprimer le cours de la liste et de la ListBox
                    listeDesCours.Remove(coursASupprimer);
                    listCours.Items.Remove(listCours.SelectedItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression du cours : {ex.Message}");
            }
        }
        private List<Note> notes = new List<Note>();

        private void button4_Click(object sender, EventArgs e)
        {
            // Vérifiez que les sélections et la note ne sont pas vides
            if (cmbEtudiant.SelectedItem == null || cmbCours.SelectedItem == null || string.IsNullOrWhiteSpace(txtNote.Text))
            {
                MessageBox.Show("Veuillez sélectionner un étudiant et un cours et saisir la note.");
                return;
            }

            float note;
            try
            {
                note = float.Parse(txtNote.Text); // Assurez-vous que le texte peut être converti en float
            }
            catch (FormatException)
            {
                MessageBox.Show("La note doit être un nombre valide.");
                return;
            }

            int numeroEtudiant = ((Etudiant)cmbEtudiant.SelectedItem).NumeroEtudiant;
            int numeroCours = ((Cours)cmbCours.SelectedItem).NumeroCours;

            // Créer un objet Note
            Note nouvelleNote = new Note(numeroEtudiant, numeroCours, note);

            // Ajouter l'objet Note à la liste des notes
            notes.Add(nouvelleNote);

            // Optionnel : Vider le TextBox de la note
            txtNote.Clear();
            string textToAdd = $"{numeroEtudiant};{numeroCours};{note}";

            // Chemin du fichier texte où enregistrer les notes
            string path = @"C:\Users\amira\OneDrive\Bureau\Dossier etudiant\Note.txt";

            try
            {
                // Écrire la note dans le fichier texte
                using (StreamWriter writer = new StreamWriter(path, true)) // 'true' pour ajouter au fichier existant
                {
                    writer.WriteLine(textToAdd);
                }

                MessageBox.Show("Note ajoutée avec succès.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numeroEtudiant = ((Etudiant)cmbEtudiant.SelectedItem).NumeroEtudiant;

            // Filtrer les notes pour l'étudiant sélectionné
            var notesDeLEtudiant = notes.Where(n => n.NumeroEtudiant == numeroEtudiant).ToList();

            // Mettre à jour l'affichage des notes
            // Si vous utilisez un ListBox:
            listNote.DataSource = null;
            listNote.Items.Clear();
            foreach (var note in notesDeLEtudiant)
            {
                listNote.Items.Add(note);
            }

            // Si vous utilisez un DataGridView:
            listNote.DataSource = notesDeLEtudiant;

        }

        
        private void RemplirComboBoxEtudiants()
        {
            // Supposons que vous ayez une méthode qui lit les étudiants depuis un fichier ou une base de données et les stocke dans une liste
            List<Etudiant> listeEtudiants = ObtenirLesEtudiants();

            cmbEtudiant.DataSource = listeEtudiants;
            cmbEtudiant.DisplayMember = "NomComplet"; // Supposons que vous ayez une propriété "NomComplet" dans la classe Etudiant qui retourne "Nom Prenom"
            cmbEtudiant.ValueMember = "NumeroEtudiant";
        }

    

        private void RemplirComboBoxCours()
        {
            // De même pour les cours
            List<Cours> listeCours = ObtenirLesCours();
            MessageBox.Show($"Nombre de cours chargés : {listeCours.Count}");

            cmbCours.DataSource = listeCours;
            cmbCours.DisplayMember = "Titre"; // Supposons que "Titre" soit une propriété de la classe Cours
            cmbCours.ValueMember = "NumeroCours";
        }
        private List<Etudiant> ObtenirLesEtudiants()
        {
            List<Etudiant> etudiants = new List<Etudiant>();
            string path = @"C:\Users\amira\OneDrive\Bureau\Dossier etudiant\Etudiant.txt"; // Votre chemin de fichier

            try
            {
                // Vérifiez si le fichier existe avant de tenter de le lire
                if (File.Exists(path))
                {
                    var lines = File.ReadAllLines(path);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(';');
                        if (parts.Length >= 3 && int.TryParse(parts[0], out var numero))
                        {
                            etudiants.Add(new Etudiant
                            {
                                NumeroEtudiant = numero,
                                Nom = parts[1],
                                Prenom = parts[2]
                            });
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Le fichier à l'emplacement suivant n'a pas été trouvé: {path}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la lecture du fichier: {ex.Message}");
            }

            return etudiants;
        }

        private List<Cours> ObtenirLesCours()
            
        {
            List<Cours> listeCours = new List<Cours>();
            string path = @"C:\Users\amira\OneDrive\Bureau\Dossier etudiant\Cours.txt"; ; // Votre chemin de fichier

            try
            {
                // Vérifiez si le fichier existe avant de tenter de le lire
                if (File.Exists(path))
                {
                    var lines = File.ReadAllLines(path);
                    MessageBox.Show($"Nombre de lignes lues : {lines.Length}");
                    foreach (var line in lines)
                    {
                        var parts = line.Split(';');
                        if (parts.Length >= 3 && int.TryParse(parts[0], out var numero))
                        {
                           // listeCours.Add(new Cours
                           var Cours = new Cours
                            {
                                NumeroCours = numero,
                                Code = parts[1],
                                Titre = parts[2]
                            };
                            MessageBox.Show($"Cours chargé : {Cours.NumeroCours} {Cours.Code} {Cours.Titre}"); // Pour le débogage
                            listeCours.Add(Cours);
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Le fichier à l'emplacement suivant n'a pas été trouvé: {path}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la lecture du fichier: {ex.Message}");
            }

            return listeCours;
           

        }


        private void label9_Click(object sender, EventArgs e)
        {

        }



        private void button6_Click(object sender, EventArgs e)
        {
            int numeroEtudiant;
            if (int.TryParse(txtNumeroEtudiantPourImpression.Text, out numeroEtudiant))
            {
                string dossierEtudiant = @"C:\Users\amira\OneDrive\Bureau\Dossier etudiant";
                string cheminFichierNote = Path.Combine(dossierEtudiant, "Note.txt");
                string cheminFichierCours = Path.Combine(dossierEtudiant, "Cours.txt");
                string cheminFichierEtudiant = Path.Combine(dossierEtudiant, "Etudiant.txt");

                if (File.Exists(cheminFichierEtudiant))
                {
                    string[] lignesEtudiant = File.ReadAllLines(cheminFichierEtudiant);

                    if (lignesEtudiant.Any(line => line.StartsWith($"{numeroEtudiant};")))
                    {
                        if (File.Exists(cheminFichierNote) && File.Exists(cheminFichierCours))
                        {
                            string[] lignesNotes = File.ReadAllLines(cheminFichierNote);
                            string[] lignesCours = File.ReadAllLines(cheminFichierCours);

                            var query = from note in lignesNotes
                                        join cours in lignesCours on note.Split(';')[1] equals cours.Split(';')[0]
                                        join etudiant in lignesEtudiant on note.Split(';')[0] equals etudiant.Split(';')[0]
                                        where etudiant.Split(';')[0] == numeroEtudiant.ToString()
                                        select new
                                        {
                                            Nom = etudiant.Split(';')[1],
                                            Prenom = etudiant.Split(';')[2],
                                            TitreCours = cours.Split(';')[2],
                                            Note = note.Split(';')[2]
                                        };

                            string nomFichierResultat = $"Resultat_{query.FirstOrDefault().Nom}_{query.FirstOrDefault().Prenom}.txt";
                            string cheminFichierResultat = Path.Combine(dossierEtudiant, nomFichierResultat);

                            using (StreamWriter writer = new StreamWriter(cheminFichierResultat))
                            {
                                foreach (var result in query)
                                {
                                    writer.WriteLine($"{result.Nom} {result.Prenom} a eu la note {result.Note} dans la matière {result.TitreCours}");
                                }
                            }

                            MessageBox.Show($"Résultats enregistrés dans le fichier {nomFichierResultat}");
                        }
                        else
                        {
                            MessageBox.Show("Certains fichiers nécessaires n'existent pas.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aucun étudiant trouvé avec ce numéro.");
                    }
                }
                else
                {
                    MessageBox.Show("Fichier des étudiants introuvable.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un numéro d'étudiant valide.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     

        private void button7_Click(object sender, EventArgs e)
        {

            // Chemin du fichier texte où les notes sont enregistrées
            string path = @"C:\Users\amira\OneDrive\Bureau\Dossier etudiant\Note.txt";

            // Vider la liste actuelle des notes avant de la remplir avec de nouvelles données
            notes.Clear();

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 3 &&
                        int.TryParse(parts[0], out int numeroEtudiant) &&
                        int.TryParse(parts[1], out int numeroCours) &&
                        float.TryParse(parts[2], out float noteValue))
                    {
                        // Utilisation du constructeur de votre classe Note
                        Note note = new Note(numeroEtudiant, numeroCours, noteValue);
                        notes.Add(note);
                    }
                }

                // Mettre à jour la ListBox avec les notes
                listNote.DataSource = notes;
                listNote.DisplayMember = "DisplayText"; // Assurez-vous d'avoir une propriété DisplayText dans votre classe Note
            }
            else
            {
                MessageBox.Show("Le fichier de notes n'a pas été trouvé.");
            }
        }

    }
        // Variable globale pour stocker le texte à imprimer
        /* private string texteAImprimer;

         private void button6_Click(object sender, EventArgs e)

         {
             Exception ex = new Exception();
             // ... (Le reste de votre code pour charger les données)

             if (int.TryParse(txtNumeroEtudiantPourImpression.Text, out int numeroEtudiant))
             {
                 // Trouvez l'étudiant correspondant
                 var etudiant = listeEtudiants.FirstOrDefault(e => e.NumeroEtudiant == numeroEtudiant);
                 if (etudiant != null)
                 {
                     var notesEtudiant = notes.Where(n => n.NumeroEtudiant == numeroEtudiant).ToList();
                     texteAImprimer = $"Informations pour l'étudiant numéro {numeroEtudiant}:\n" +
                                      $"{etudiant.Nom} {etudiant.Prenom}\n\n" +
                                      "Notes:\n";

                     // Ajoutez les informations de cours et de notes
                     foreach (var note in notesEtudiant)
                     {
                         var cours = listeDesCours.FirstOrDefault(c => c.NumeroCours == note.NumeroCours);
                         texteAImprimer += $@"Cours: {cours.Titre}, Note: {note.Notes}\n";
                     }

                     // Configurez et démarrez l'impression
                     PrintDocument pd = new PrintDocument();
                     pd.PrintPage += PrintPage;
                     PrintDialog printDialog = new PrintDialog();
                     printDialog.Document = pd;

                     if (printDialog.ShowDialog() == DialogResult.OK)
                     {
                         pd.Print();
                     }
                 }
                 else
                 {
                     MessageBox.Show("L'étudiant n'a pas été trouvé.");
                 }
             }
             else
             {
                 MessageBox.Show("Veuillez entrer un numéro d'étudiant valide.");
             }
         }

         private void PrintPage(object sender, PrintPageEventArgs e)
         {
             e.Graphics.DrawString(texteAImprimer, new Font("Arial", 12), Brushes.Black, e.MarginBounds);
         }
        */
    }


    
    
    

