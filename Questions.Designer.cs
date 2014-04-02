namespace WindowsFormsApplication1
{
    partial class Questions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questions));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.question_sql = new System.Windows.Forms.TextBox();
            this.question_gen = new System.Windows.Forms.Button();
            this.question_id = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.question_text = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.question_iffalse = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.question_conds = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.question_params = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.question_reponses = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.question_swf = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.question_sql);
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 70);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQL";
            // 
            // question_sql
            // 
            this.question_sql.BackColor = System.Drawing.SystemColors.Control;
            this.question_sql.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.question_sql.Cursor = System.Windows.Forms.Cursors.Default;
            this.question_sql.Location = new System.Drawing.Point(7, 20);
            this.question_sql.Multiline = true;
            this.question_sql.Name = "question_sql";
            this.question_sql.ReadOnly = true;
            this.question_sql.Size = new System.Drawing.Size(627, 42);
            this.question_sql.TabIndex = 0;
            // 
            // question_gen
            // 
            this.question_gen.Location = new System.Drawing.Point(230, 174);
            this.question_gen.Name = "question_gen";
            this.question_gen.Size = new System.Drawing.Size(203, 23);
            this.question_gen.TabIndex = 5;
            this.question_gen.Text = "Générer le code";
            this.question_gen.UseVisualStyleBackColor = true;
            this.question_gen.Click += new System.EventHandler(this.question_gen_Click);
            // 
            // question_id
            // 
            this.question_id.Location = new System.Drawing.Point(6, 19);
            this.question_id.Name = "question_id";
            this.question_id.Size = new System.Drawing.Size(90, 20);
            this.question_id.TabIndex = 0;
            this.question_id.Text = "ID Question";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.question_text);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.question_iffalse);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.question_conds);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.question_params);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.question_reponses);
            this.groupBox1.Controls.Add(this.question_id);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 155);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Données";
            // 
            // question_text
            // 
            this.question_text.Location = new System.Drawing.Point(121, 18);
            this.question_text.Multiline = true;
            this.question_text.Name = "question_text";
            this.question_text.Size = new System.Drawing.Size(511, 124);
            this.question_text.TabIndex = 9;
            this.question_text.Text = "Texte de la question...";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(98, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(18, 22);
            this.button4.TabIndex = 8;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // question_iffalse
            // 
            this.question_iffalse.Location = new System.Drawing.Point(7, 123);
            this.question_iffalse.Name = "question_iffalse";
            this.question_iffalse.Size = new System.Drawing.Size(90, 20);
            this.question_iffalse.TabIndex = 7;
            this.question_iffalse.Text = "ifFalse";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(18, 22);
            this.button3.TabIndex = 6;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // question_conds
            // 
            this.question_conds.Location = new System.Drawing.Point(6, 97);
            this.question_conds.Name = "question_conds";
            this.question_conds.Size = new System.Drawing.Size(90, 20);
            this.question_conds.TabIndex = 5;
            this.question_conds.Text = "Condition(s)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 22);
            this.button2.TabIndex = 4;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // question_params
            // 
            this.question_params.Location = new System.Drawing.Point(7, 71);
            this.question_params.Name = "question_params";
            this.question_params.Size = new System.Drawing.Size(90, 20);
            this.question_params.TabIndex = 3;
            this.question_params.Text = "Params";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // question_reponses
            // 
            this.question_reponses.Location = new System.Drawing.Point(7, 45);
            this.question_reponses.Name = "question_reponses";
            this.question_reponses.Size = new System.Drawing.Size(90, 20);
            this.question_reponses.TabIndex = 1;
            this.question_reponses.Text = "ID Réponses";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.question_swf);
            this.groupBox3.Location = new System.Drawing.Point(12, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 70);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SWF";
            // 
            // question_swf
            // 
            this.question_swf.BackColor = System.Drawing.SystemColors.Control;
            this.question_swf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.question_swf.Cursor = System.Windows.Forms.Cursors.Default;
            this.question_swf.Location = new System.Drawing.Point(7, 20);
            this.question_swf.Multiline = true;
            this.question_swf.Name = "question_swf";
            this.question_swf.ReadOnly = true;
            this.question_swf.Size = new System.Drawing.Size(627, 42);
            this.question_swf.TabIndex = 0;
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 363);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.question_gen);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Questions";
            this.Text = "Questions";
            this.Load += new System.EventHandler(this.Questions_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox question_sql;
        private System.Windows.Forms.Button question_gen;
        private System.Windows.Forms.TextBox question_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox question_text;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox question_iffalse;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox question_conds;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox question_params;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox question_reponses;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox question_swf;
    }
}