namespace LogicielFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroEtudiant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroCours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.listCours = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbEtudiant = new System.Windows.Forms.ComboBox();
            this.cmbCours = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.listNote = new System.Windows.Forms.ListBox();
            this.listEtudiants = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txtNumeroEtudiantPourImpression = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Etudiant:";
            // 
            // txtNumeroEtudiant
            // 
            this.txtNumeroEtudiant.Location = new System.Drawing.Point(173, 12);
            this.txtNumeroEtudiant.Name = "txtNumeroEtudiant";
            this.txtNumeroEtudiant.Size = new System.Drawing.Size(195, 26);
            this.txtNumeroEtudiant.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(173, 61);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(195, 26);
            this.txtNom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prenom";
            this.label3.Click += new System.EventHandler(this.Prenom_Click);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(173, 119);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(195, 26);
            this.txtPrenom.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Creer Etudiant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero Cours";
            // 
            // txtNumeroCours
            // 
            this.txtNumeroCours.Location = new System.Drawing.Point(558, 12);
            this.txtNumeroCours.Name = "txtNumeroCours";
            this.txtNumeroCours.Size = new System.Drawing.Size(205, 26);
            this.txtNumeroCours.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(558, 55);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(205, 26);
            this.txtCode.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Titre";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(558, 119);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(205, 26);
            this.txtTitre.TabIndex = 12;
            // 
            // listCours
            // 
            this.listCours.FormattingEnabled = true;
            this.listCours.ItemHeight = 20;
            this.listCours.Location = new System.Drawing.Point(558, 151);
            this.listCours.Name = "listCours";
            this.listCours.Size = new System.Drawing.Size(205, 144);
            this.listCours.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 51);
            this.button2.TabIndex = 14;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(723, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 54);
            this.button3.TabIndex = 15;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbEtudiant
            // 
            this.cmbEtudiant.FormattingEnabled = true;
            this.cmbEtudiant.ItemHeight = 20;
            this.cmbEtudiant.Location = new System.Drawing.Point(992, 7);
            this.cmbEtudiant.Name = "cmbEtudiant";
            this.cmbEtudiant.Size = new System.Drawing.Size(267, 28);
            this.cmbEtudiant.TabIndex = 16;
            this.cmbEtudiant.SelectedIndexChanged += new System.EventHandler(this.cmbEtudiant_SelectedIndexChanged);
            // 
            // cmbCours
            // 
            this.cmbCours.FormattingEnabled = true;
            this.cmbCours.ItemHeight = 20;
            this.cmbCours.Location = new System.Drawing.Point(992, 50);
            this.cmbCours.Name = "cmbCours";
            this.cmbCours.Size = new System.Drawing.Size(267, 28);
            this.cmbCours.TabIndex = 17;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(992, 116);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(267, 26);
            this.txtNote.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(966, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 49);
            this.button4.TabIndex = 19;
            this.button4.Text = "Ajouter Note";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listNote
            // 
            this.listNote.FormattingEnabled = true;
            this.listNote.ItemHeight = 20;
            this.listNote.Location = new System.Drawing.Point(992, 151);
            this.listNote.Name = "listNote";
            this.listNote.Size = new System.Drawing.Size(267, 144);
            this.listNote.TabIndex = 20;
            this.listNote.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listEtudiants
            // 
            this.listEtudiants.FormattingEnabled = true;
            this.listEtudiants.ItemHeight = 20;
            this.listEtudiants.Location = new System.Drawing.Point(173, 171);
            this.listEtudiants.Name = "listEtudiants";
            this.listEtudiants.Size = new System.Drawing.Size(195, 124);
            this.listEtudiants.TabIndex = 21;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(221, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 46);
            this.button5.TabIndex = 22;
            this.button5.Text = "Mis à jour";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(909, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Etudiant:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(909, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cours:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(909, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Note:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(485, 529);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(214, 64);
            this.button6.TabIndex = 26;
            this.button6.Text = "Imprimer";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtNumeroEtudiantPourImpression
            // 
            this.txtNumeroEtudiantPourImpression.Location = new System.Drawing.Point(147, 548);
            this.txtNumeroEtudiantPourImpression.Name = "txtNumeroEtudiantPourImpression";
            this.txtNumeroEtudiantPourImpression.Size = new System.Drawing.Size(235, 26);
            this.txtNumeroEtudiantPourImpression.TabIndex = 27;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1135, 316);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 46);
            this.button7.TabIndex = 28;
            this.button7.Text = "Afficher Note";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 722);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtNumeroEtudiantPourImpression);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listEtudiants);
            this.Controls.Add(this.listNote);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cmbCours);
            this.Controls.Add(this.cmbEtudiant);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listCours);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumeroCours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroEtudiant);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroEtudiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroCours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.ListBox listCours;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbEtudiant;
        private System.Windows.Forms.ComboBox cmbCours;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listNote;
        private System.Windows.Forms.ListBox listEtudiants;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtNumeroEtudiantPourImpression;
        private System.Windows.Forms.Button button7;
    }
}

