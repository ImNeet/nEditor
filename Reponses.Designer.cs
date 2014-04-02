namespace WindowsFormsApplication1
{
    partial class Reponses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reponses));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rid = new System.Windows.Forms.TextBox();
            this.ra = new System.Windows.Forms.TextBox();
            this.rty = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rswf = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rsql = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rt);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.rid);
            this.groupBox1.Controls.Add(this.ra);
            this.groupBox1.Controls.Add(this.rty);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Données";
            // 
            // rt
            // 
            this.rt.Location = new System.Drawing.Point(123, 19);
            this.rt.Multiline = true;
            this.rt.Name = "rt";
            this.rt.Size = new System.Drawing.Size(511, 73);
            this.rt.TabIndex = 16;
            this.rt.Text = "Texte de la réponse...";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 22);
            this.button2.TabIndex = 15;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rid
            // 
            this.rid.Location = new System.Drawing.Point(9, 20);
            this.rid.Name = "rid";
            this.rid.Size = new System.Drawing.Size(90, 20);
            this.rid.TabIndex = 11;
            this.rid.Text = "ID Réponse";
            // 
            // ra
            // 
            this.ra.Location = new System.Drawing.Point(9, 72);
            this.ra.Name = "ra";
            this.ra.Size = new System.Drawing.Size(90, 20);
            this.ra.TabIndex = 14;
            this.ra.Text = "Args";
            // 
            // rty
            // 
            this.rty.Location = new System.Drawing.Point(9, 46);
            this.rty.Name = "rty";
            this.rty.Size = new System.Drawing.Size(90, 20);
            this.rty.TabIndex = 12;
            this.rty.Text = "Type";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(18, 22);
            this.button3.TabIndex = 13;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rswf);
            this.groupBox3.Location = new System.Drawing.Point(13, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 70);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SWF";
            // 
            // rswf
            // 
            this.rswf.BackColor = System.Drawing.SystemColors.Control;
            this.rswf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rswf.Cursor = System.Windows.Forms.Cursors.Default;
            this.rswf.Location = new System.Drawing.Point(7, 20);
            this.rswf.Multiline = true;
            this.rswf.Name = "rswf";
            this.rswf.ReadOnly = true;
            this.rswf.Size = new System.Drawing.Size(627, 42);
            this.rswf.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rsql);
            this.groupBox2.Location = new System.Drawing.Point(13, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 70);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQL";
            // 
            // rsql
            // 
            this.rsql.BackColor = System.Drawing.SystemColors.Control;
            this.rsql.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rsql.Cursor = System.Windows.Forms.Cursors.Default;
            this.rsql.Location = new System.Drawing.Point(7, 20);
            this.rsql.Multiline = true;
            this.rsql.Name = "rsql";
            this.rsql.ReadOnly = true;
            this.rsql.Size = new System.Drawing.Size(627, 42);
            this.rsql.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Générer le code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reponses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reponses";
            this.Text = "Réponses";
            this.Load += new System.EventHandler(this.Reponses_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox rswf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox rsql;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox rt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox rid;
        private System.Windows.Forms.TextBox ra;
        private System.Windows.Forms.TextBox rty;
        private System.Windows.Forms.Button button3;
    }
}