namespace WindowsFormsApplication1
{
    partial class Crafts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crafts));
            this.idc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cq = new System.Windows.Forms.TextBox();
            this.cid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.csql = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cswf = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // idc
            // 
            this.idc.Location = new System.Drawing.Point(69, 12);
            this.idc.Name = "idc";
            this.idc.Size = new System.Drawing.Size(75, 20);
            this.idc.TabIndex = 0;
            this.idc.Text = "ID item crafté";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cq);
            this.groupBox1.Controls.Add(this.cid);
            this.groupBox1.Location = new System.Drawing.Point(13, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Composants";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cq
            // 
            this.cq.Location = new System.Drawing.Point(7, 47);
            this.cq.Name = "cq";
            this.cq.Size = new System.Drawing.Size(192, 20);
            this.cq.TabIndex = 1;
            this.cq.Text = "Quantité";
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(7, 20);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(192, 20);
            this.cid.TabIndex = 0;
            this.cid.Text = "ID composant";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Générer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.csql);
            this.groupBox2.Location = new System.Drawing.Point(224, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 67);
            this.groupBox2.TabIndex = 3;
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
            this.csql.Size = new System.Drawing.Size(274, 42);
            this.csql.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cswf);
            this.groupBox3.Location = new System.Drawing.Point(224, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 87);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SWF";
            // 
            // cswf
            // 
            this.cswf.BackColor = System.Drawing.SystemColors.Control;
            this.cswf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cswf.Cursor = System.Windows.Forms.Cursors.Default;
            this.cswf.Location = new System.Drawing.Point(6, 19);
            this.cswf.Multiline = true;
            this.cswf.Name = "cswf";
            this.cswf.ReadOnly = true;
            this.cswf.Size = new System.Drawing.Size(274, 62);
            this.cswf.TabIndex = 2;
            // 
            // Crafts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 189);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.idc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Crafts";
            this.Text = "Crafts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cq;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox csql;
        private System.Windows.Forms.TextBox cswf;
    }
}