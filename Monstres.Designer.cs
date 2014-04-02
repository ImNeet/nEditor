namespace WindowsFormsApplication1
{
    partial class Monstres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monstres));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mkmax = new System.Windows.Forms.TextBox();
            this.mkmin = new System.Windows.Forms.TextBox();
            this.mexp = new System.Windows.Forms.TextBox();
            this.mlvl = new System.Windows.Forms.TextBox();
            this.mgfx = new System.Windows.Forms.TextBox();
            this.mname = new System.Windows.Forms.TextBox();
            this.mid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mpm = new System.Windows.Forms.TextBox();
            this.mpa = new System.Windows.Forms.TextBox();
            this.mv = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mepm = new System.Windows.Forms.TextBox();
            this.mepa = new System.Windows.Forms.TextBox();
            this.mre = new System.Windows.Forms.TextBox();
            this.mra = new System.Windows.Forms.TextBox();
            this.mrf = new System.Windows.Forms.TextBox();
            this.mrt = new System.Windows.Forms.TextBox();
            this.mrn = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mc = new System.Windows.Forms.TextBox();
            this.ma = new System.Windows.Forms.TextBox();
            this.mi = new System.Windows.Forms.TextBox();
            this.mf = new System.Windows.Forms.TextBox();
            this.ms = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.msf = new System.Windows.Forms.TextBox();
            this.madd = new System.Windows.Forms.Button();
            this.msl = new System.Windows.Forms.TextBox();
            this.msid = new System.Windows.Forms.TextBox();
            this.mgen = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.msql = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.mswf = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mkmax);
            this.groupBox1.Controls.Add(this.mkmin);
            this.groupBox1.Controls.Add(this.mexp);
            this.groupBox1.Controls.Add(this.mlvl);
            this.groupBox1.Controls.Add(this.mgfx);
            this.groupBox1.Controls.Add(this.mname);
            this.groupBox1.Controls.Add(this.mid);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations générales";
            // 
            // mkmax
            // 
            this.mkmax.Location = new System.Drawing.Point(327, 19);
            this.mkmax.Name = "mkmax";
            this.mkmax.Size = new System.Drawing.Size(100, 20);
            this.mkmax.TabIndex = 6;
            this.mkmax.Text = "Kamas max";
            // 
            // mkmin
            // 
            this.mkmin.Location = new System.Drawing.Point(220, 19);
            this.mkmin.Name = "mkmin";
            this.mkmin.Size = new System.Drawing.Size(100, 20);
            this.mkmin.TabIndex = 5;
            this.mkmin.Text = "Kamas min";
            // 
            // mexp
            // 
            this.mexp.Location = new System.Drawing.Point(433, 45);
            this.mexp.Name = "mexp";
            this.mexp.Size = new System.Drawing.Size(100, 20);
            this.mexp.TabIndex = 4;
            this.mexp.Text = "Expérience";
            // 
            // mlvl
            // 
            this.mlvl.Location = new System.Drawing.Point(433, 19);
            this.mlvl.Name = "mlvl";
            this.mlvl.Size = new System.Drawing.Size(100, 20);
            this.mlvl.TabIndex = 3;
            this.mlvl.Text = "Niveau";
            // 
            // mgfx
            // 
            this.mgfx.Location = new System.Drawing.Point(163, 19);
            this.mgfx.Name = "mgfx";
            this.mgfx.Size = new System.Drawing.Size(51, 20);
            this.mgfx.TabIndex = 2;
            this.mgfx.Text = "GfxID";
            // 
            // mname
            // 
            this.mname.Location = new System.Drawing.Point(56, 19);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(100, 20);
            this.mname.TabIndex = 1;
            this.mname.Text = "Nom du monstre";
            // 
            // mid
            // 
            this.mid.Location = new System.Drawing.Point(7, 20);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(42, 20);
            this.mid.TabIndex = 0;
            this.mid.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mpm);
            this.groupBox2.Controls.Add(this.mpa);
            this.groupBox2.Controls.Add(this.mv);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(13, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistiques";
            // 
            // mpm
            // 
            this.mpm.Location = new System.Drawing.Point(299, 19);
            this.mpm.Name = "mpm";
            this.mpm.Size = new System.Drawing.Size(25, 20);
            this.mpm.TabIndex = 4;
            this.mpm.Text = "PM";
            // 
            // mpa
            // 
            this.mpa.Location = new System.Drawing.Point(268, 19);
            this.mpa.Name = "mpa";
            this.mpa.Size = new System.Drawing.Size(24, 20);
            this.mpa.TabIndex = 3;
            this.mpa.Text = "PA";
            // 
            // mv
            // 
            this.mv.Location = new System.Drawing.Point(161, 19);
            this.mv.Name = "mv";
            this.mv.Size = new System.Drawing.Size(100, 20);
            this.mv.TabIndex = 2;
            this.mv.Text = "Vie";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mepm);
            this.groupBox4.Controls.Add(this.mepa);
            this.groupBox4.Controls.Add(this.mre);
            this.groupBox4.Controls.Add(this.mra);
            this.groupBox4.Controls.Add(this.mrf);
            this.groupBox4.Controls.Add(this.mrt);
            this.groupBox4.Controls.Add(this.mrn);
            this.groupBox4.Location = new System.Drawing.Point(267, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 155);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Résistances";
            // 
            // mepm
            // 
            this.mepm.Location = new System.Drawing.Point(158, 86);
            this.mepm.Name = "mepm";
            this.mepm.Size = new System.Drawing.Size(100, 20);
            this.mepm.TabIndex = 6;
            this.mepm.Text = "Esquive PM";
            // 
            // mepa
            // 
            this.mepa.Location = new System.Drawing.Point(158, 60);
            this.mepa.Name = "mepa";
            this.mepa.Size = new System.Drawing.Size(100, 20);
            this.mepa.TabIndex = 5;
            this.mepa.Text = "Esquive PA";
            // 
            // mre
            // 
            this.mre.Location = new System.Drawing.Point(7, 128);
            this.mre.Name = "mre";
            this.mre.Size = new System.Drawing.Size(100, 20);
            this.mre.TabIndex = 4;
            this.mre.Text = "Résistance eau";
            // 
            // mra
            // 
            this.mra.Location = new System.Drawing.Point(7, 101);
            this.mra.Name = "mra";
            this.mra.Size = new System.Drawing.Size(100, 20);
            this.mra.TabIndex = 3;
            this.mra.Text = "Résistance air";
            // 
            // mrf
            // 
            this.mrf.Location = new System.Drawing.Point(7, 74);
            this.mrf.Name = "mrf";
            this.mrf.Size = new System.Drawing.Size(100, 20);
            this.mrf.TabIndex = 2;
            this.mrf.Text = "Résistance feu";
            // 
            // mrt
            // 
            this.mrt.Location = new System.Drawing.Point(7, 47);
            this.mrt.Name = "mrt";
            this.mrt.Size = new System.Drawing.Size(100, 20);
            this.mrt.TabIndex = 1;
            this.mrt.Text = "Résistance terre";
            // 
            // mrn
            // 
            this.mrn.Location = new System.Drawing.Point(7, 20);
            this.mrn.Name = "mrn";
            this.mrn.Size = new System.Drawing.Size(100, 20);
            this.mrn.TabIndex = 0;
            this.mrn.Text = "Résistance neutre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mc);
            this.groupBox3.Controls.Add(this.ma);
            this.groupBox3.Controls.Add(this.mi);
            this.groupBox3.Controls.Add(this.mf);
            this.groupBox3.Controls.Add(this.ms);
            this.groupBox3.Location = new System.Drawing.Point(7, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 155);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Caractéristiques";
            // 
            // mc
            // 
            this.mc.Location = new System.Drawing.Point(7, 128);
            this.mc.Name = "mc";
            this.mc.Size = new System.Drawing.Size(100, 20);
            this.mc.TabIndex = 4;
            this.mc.Text = "Chance";
            // 
            // ma
            // 
            this.ma.Location = new System.Drawing.Point(7, 101);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(100, 20);
            this.ma.TabIndex = 3;
            this.ma.Text = "Agilité";
            // 
            // mi
            // 
            this.mi.Location = new System.Drawing.Point(7, 74);
            this.mi.Name = "mi";
            this.mi.Size = new System.Drawing.Size(100, 20);
            this.mi.TabIndex = 2;
            this.mi.Text = "Intelligence";
            // 
            // mf
            // 
            this.mf.Location = new System.Drawing.Point(7, 47);
            this.mf.Name = "mf";
            this.mf.Size = new System.Drawing.Size(100, 20);
            this.mf.TabIndex = 1;
            this.mf.Text = "Force";
            // 
            // ms
            // 
            this.ms.Location = new System.Drawing.Point(7, 20);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(100, 20);
            this.ms.TabIndex = 0;
            this.ms.Text = "Sagesse";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.msf);
            this.groupBox5.Controls.Add(this.madd);
            this.groupBox5.Controls.Add(this.msl);
            this.groupBox5.Controls.Add(this.msid);
            this.groupBox5.Location = new System.Drawing.Point(13, 320);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(542, 49);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sorts";
            // 
            // msf
            // 
            this.msf.Location = new System.Drawing.Point(270, 20);
            this.msf.Multiline = true;
            this.msf.Name = "msf";
            this.msf.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msf.Size = new System.Drawing.Size(266, 20);
            this.msf.TabIndex = 5;
            // 
            // madd
            // 
            this.madd.Location = new System.Drawing.Point(189, 18);
            this.madd.Name = "madd";
            this.madd.Size = new System.Drawing.Size(75, 23);
            this.madd.TabIndex = 4;
            this.madd.Text = "Ajouter";
            this.madd.UseVisualStyleBackColor = true;
            this.madd.Click += new System.EventHandler(this.madd_Click);
            // 
            // msl
            // 
            this.msl.Location = new System.Drawing.Point(113, 20);
            this.msl.Name = "msl";
            this.msl.Size = new System.Drawing.Size(70, 20);
            this.msl.TabIndex = 3;
            this.msl.Text = "Niveau sort";
            // 
            // msid
            // 
            this.msid.Location = new System.Drawing.Point(7, 20);
            this.msid.Name = "msid";
            this.msid.Size = new System.Drawing.Size(100, 20);
            this.msid.TabIndex = 0;
            this.msid.Text = "ID Sort";
            // 
            // mgen
            // 
            this.mgen.Location = new System.Drawing.Point(233, 375);
            this.mgen.Name = "mgen";
            this.mgen.Size = new System.Drawing.Size(75, 23);
            this.mgen.TabIndex = 3;
            this.mgen.Text = "Générer";
            this.mgen.UseVisualStyleBackColor = true;
            this.mgen.Click += new System.EventHandler(this.mgen_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.msql);
            this.groupBox6.Location = new System.Drawing.Point(12, 404);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(542, 82);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SQL";
            // 
            // msql
            // 
            this.msql.BackColor = System.Drawing.SystemColors.Control;
            this.msql.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msql.Cursor = System.Windows.Forms.Cursors.Default;
            this.msql.Location = new System.Drawing.Point(6, 19);
            this.msql.Multiline = true;
            this.msql.Name = "msql";
            this.msql.ReadOnly = true;
            this.msql.Size = new System.Drawing.Size(530, 57);
            this.msql.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.mswf);
            this.groupBox7.Location = new System.Drawing.Point(13, 492);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(542, 82);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "SWF";
            // 
            // mswf
            // 
            this.mswf.BackColor = System.Drawing.SystemColors.Control;
            this.mswf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mswf.Cursor = System.Windows.Forms.Cursors.Default;
            this.mswf.Location = new System.Drawing.Point(5, 19);
            this.mswf.Multiline = true;
            this.mswf.Name = "mswf";
            this.mswf.ReadOnly = true;
            this.mswf.Size = new System.Drawing.Size(530, 57);
            this.mswf.TabIndex = 2;
            // 
            // Monstres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 589);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.mgen);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Monstres";
            this.Text = "Monstre";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mkmax;
        private System.Windows.Forms.TextBox mkmin;
        private System.Windows.Forms.TextBox mexp;
        private System.Windows.Forms.TextBox mlvl;
        private System.Windows.Forms.TextBox mgfx;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.TextBox mid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox mpm;
        private System.Windows.Forms.TextBox mpa;
        private System.Windows.Forms.TextBox mv;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox mepm;
        private System.Windows.Forms.TextBox mepa;
        private System.Windows.Forms.TextBox mre;
        private System.Windows.Forms.TextBox mra;
        private System.Windows.Forms.TextBox mrf;
        private System.Windows.Forms.TextBox mrt;
        private System.Windows.Forms.TextBox mrn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox mc;
        private System.Windows.Forms.TextBox ma;
        private System.Windows.Forms.TextBox mi;
        private System.Windows.Forms.TextBox mf;
        private System.Windows.Forms.TextBox ms;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button madd;
        private System.Windows.Forms.TextBox msl;
        private System.Windows.Forms.TextBox msid;
        private System.Windows.Forms.Button mgen;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox msql;
        private System.Windows.Forms.TextBox mswf;
        private System.Windows.Forms.TextBox msf;


    }
}