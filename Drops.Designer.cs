namespace WindowsFormsApplication1
{
    partial class Drops
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drops));
            this.drop_monster = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drop_chance = new System.Windows.Forms.TextBox();
            this.drop_max = new System.Windows.Forms.TextBox();
            this.drop_pp = new System.Windows.Forms.TextBox();
            this.drop_item = new System.Windows.Forms.TextBox();
            this.drop_gen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.drop_sql = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // drop_monster
            // 
            this.drop_monster.Location = new System.Drawing.Point(6, 19);
            this.drop_monster.Name = "drop_monster";
            this.drop_monster.Size = new System.Drawing.Size(100, 20);
            this.drop_monster.TabIndex = 0;
            this.drop_monster.Text = "ID Monstre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drop_chance);
            this.groupBox1.Controls.Add(this.drop_max);
            this.groupBox1.Controls.Add(this.drop_pp);
            this.groupBox1.Controls.Add(this.drop_item);
            this.groupBox1.Controls.Add(this.drop_monster);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Données";
            // 
            // drop_chance
            // 
            this.drop_chance.Location = new System.Drawing.Point(430, 19);
            this.drop_chance.Name = "drop_chance";
            this.drop_chance.Size = new System.Drawing.Size(100, 20);
            this.drop_chance.TabIndex = 4;
            this.drop_chance.Text = "% de chance";
            // 
            // drop_max
            // 
            this.drop_max.Location = new System.Drawing.Point(324, 19);
            this.drop_max.Name = "drop_max";
            this.drop_max.Size = new System.Drawing.Size(100, 20);
            this.drop_max.TabIndex = 3;
            this.drop_max.Text = "Nombre max";
            // 
            // drop_pp
            // 
            this.drop_pp.Location = new System.Drawing.Point(218, 19);
            this.drop_pp.Name = "drop_pp";
            this.drop_pp.Size = new System.Drawing.Size(100, 20);
            this.drop_pp.TabIndex = 2;
            this.drop_pp.Text = "PP Minimale";
            // 
            // drop_item
            // 
            this.drop_item.Location = new System.Drawing.Point(112, 19);
            this.drop_item.Name = "drop_item";
            this.drop_item.Size = new System.Drawing.Size(100, 20);
            this.drop_item.TabIndex = 1;
            this.drop_item.Text = "ID item";
            // 
            // drop_gen
            // 
            this.drop_gen.Location = new System.Drawing.Point(230, 71);
            this.drop_gen.Name = "drop_gen";
            this.drop_gen.Size = new System.Drawing.Size(100, 23);
            this.drop_gen.TabIndex = 2;
            this.drop_gen.Text = "Générer la ligne";
            this.drop_gen.UseVisualStyleBackColor = true;
            this.drop_gen.Click += new System.EventHandler(this.drop_gen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.drop_sql);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 70);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQL";
            // 
            // drop_sql
            // 
            this.drop_sql.BackColor = System.Drawing.SystemColors.Control;
            this.drop_sql.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drop_sql.Cursor = System.Windows.Forms.Cursors.Default;
            this.drop_sql.Location = new System.Drawing.Point(7, 20);
            this.drop_sql.Multiline = true;
            this.drop_sql.Name = "drop_sql";
            this.drop_sql.ReadOnly = true;
            this.drop_sql.Size = new System.Drawing.Size(523, 42);
            this.drop_sql.TabIndex = 0;
            // 
            // Drops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 185);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.drop_gen);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Drops";
            this.ShowInTaskbar = false;
            this.Text = "Drop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox drop_monster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox drop_chance;
        private System.Windows.Forms.TextBox drop_max;
        private System.Windows.Forms.TextBox drop_pp;
        private System.Windows.Forms.TextBox drop_item;
        private System.Windows.Forms.Button drop_gen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox drop_sql;
    }
}