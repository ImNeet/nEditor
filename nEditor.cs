using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class nEditor : Form
    {
        public nEditor()
        {
            InitializeComponent();
        }

        private void réponseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dropsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                Drops childForm = new Drops();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void questionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Questions childForm = new Questions();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void nEditor_Load(object sender, EventArgs e)
        {
            Form1 childForm = new Form1();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void réponseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Reponses childForm = new Reponses();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void monstreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monstres childForm = new Monstres();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void craftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crafts childForm = new Crafts();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void scriptedCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIA childForm = new UIA();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void informationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 childForm = new Form1();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
