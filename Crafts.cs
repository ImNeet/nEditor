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
    public partial class Crafts : Form
    {
        private String ComposantsSQL;
        private String ComposantsSWF;

        public Crafts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComposantsSQL += cid.Text+"*"+cq.Text+";";
            ComposantsSWF += "[" + cid.Text + ", " + cq.Text + "], ";

            MessageBox.Show(cq.Text + " objets correspondant à l'ID " + cid.Text + " ont été ajoutés à la recette !",
             "Composant ajouté !",
             MessageBoxButtons.OK,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button1);

            cid.Text = "";
            cq.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComposantsSQL = ComposantsSQL.Substring(0, ComposantsSQL.Length - 1);
            csql.Text = "INSERT INTO `crafts` VALUES ('" + idc.Text + "', '" + ComposantsSQL + "');";

            ComposantsSWF = ComposantsSWF.Substring(0, ComposantsSWF.Length - 2);
            cswf.Text = "CR[" + idc.Text + "] = [" + ComposantsSWF + "];";
        }
    }
}
