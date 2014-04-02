namespace WindowsFormsApplication1
{
    partial class UIA
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.csql = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Item ID";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Ajout d\'xp metier = 17, IDJob,Nbr",
            "Ajout de point d\'honneur = 16, Nbr",
            "Ajout métier + outil = 98, Pas d\'arg",
            "Ajouter de l\'energie = 21,Nbr",
            "Ajouter de l\'xp = 22, Nbr",
            "Ajouter des kamas = 4, Nombredekamas",
            "Ajouter un objet = 5, IdObj,Nombre (Si vous mettez un nombre négatif, cela va sup" +
                "rimmer l\'item.)",
            "Ajouter une stats = 8, IdStats, Nbr (Si vous mettez un nombre negatif cela enleve" +
                "ra des stats)",
            "Ajoutez des point de sort = 20, Nbr",
            "Apprendre un metier = 6, IDMetier ",
            "Apprendre un sort = 9, IdSort",
            "Case mariage : 101, Pas d\'arguments ",
            "Changer de morph = 24,Idmorph",
            "Cibler la traque = 51, Pas d\'arguments",
            "Créer une guilde = -2, Pas d\'arguments",
            "Definir un alignement = 11, AlignID",
            "Descendre de la monture = 105, Pas d\'arg",
            "Dialogue NPC = 1,QuestionID Ou si vous voullez arrêter le dialog, mettez DV en Ar" +
                "guments.  ",
            "Divorcer : 103, Pas d\'arguments",
            "Donner une abilité à une dragodinde : 100, IdAbilité",
            "Gagner énergie (bonbon) = 104,",
            "Lancer un combat = 27,IdMonstre,LevelMonstre|Ect..",
            "Lancer une animation hors combat : 228, AnimationID",
            "Lancer une traque = 50, Pas d\'arguments",
            "Manger un pain,potion,viande,poisson = 10, GaindeVieMini,GainDeVieMaxi",
            "Monter sur la monture = 2, Pas d\'arguments",
            "Oublié un metier = 23,IdMetier",
            "Oublier un sort (Interface) = 14, pas d\'arguments",
            "Ouverture du panel de guilde maison = 19, Pas d\'arguments",
            "Ouvrir une banque = -1, Pas d\'arguments",
            "recompense de traque = 52, pas d\'arguments",
            "Restats = 13, Pas d\'arguments ",
            "Retourner au point de sauvegarde = 7, Pas d\'arguments",
            "Retrouver son apparance normal = 25, Pas d\'arguments",
            "Se Marier : 102, Pas d\'arguments",
            "Spawn  un groupe de monstre = 12, Boolean(True/False)DelObjet, Boolean(True/False" +
                ")InArena",
            "Téléportation = 0, Mapid,Cellid",
            "Teleportation dans votre maison = 18, Pas d\'arguments",
            "Teleportation donjon (Clef) = 15, MapidOuVousSerezTeleport,CellidOuVousSerezTelep" +
                "ort,IdObjetRequis(Peut-être mis à 0 pour anuler),MapidOuEstLeNpc(Mapid Requis)(P" +
                "eut-être mis à 0 pour anuler.)    ",
            "Teleportation enclos de guilde(Ouverture du Panel) = 26, pas d\'arguments",
            "Téléporte arène = 99, Pas d\'arg"});
            this.listBox1.Location = new System.Drawing.Point(119, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(600, 95);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Args";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Générer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.csql);
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQL";
            // 
            // csql
            // 
            this.csql.BackColor = System.Drawing.SystemColors.Control;
            this.csql.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.csql.Cursor = System.Windows.Forms.Cursors.Default;
            this.csql.Location = new System.Drawing.Point(6, 19);
            this.csql.Multiline = true;
            this.csql.Name = "csql";
            this.csql.ReadOnly = true;
            this.csql.Size = new System.Drawing.Size(701, 45);
            this.csql.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Type";
            // 
            // UIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 195);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UIA";
            this.Text = "Item action";
            this.Load += new System.EventHandler(this.UIA_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox csql;
        private System.Windows.Forms.TextBox textBox3;
    }
}