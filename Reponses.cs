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
    public partial class Reponses : Form
    {
        public Reponses()
        {
            InitializeComponent();
        }

        private void Reponses_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Le type correspond à l'action qui suit le choix de la réponse.\n"
             + "Les actions sont définies dans votre émulateur.",
             "Types",
             MessageBoxButtons.OK,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Les args sont les arguments qui complètent l'action de la réponse.\n"
             + "Il s'agira par exemple de l'ID de la carte suivit de la cellule d'arrivée pour une téléportation, qui sera notée ainsi :\n"
             + "MapID,CellID",
             "Args",
             MessageBoxButtons.OK,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rsql.Text = "INSERT INTO `npc_reponses_actions` VALUES ('" + rid.Text + "', '" + rty.Text + "', '" + ra.Text + "');";
            rswf.Text = "D.a[" + rid.Text + "] = \"" + rt.Text + "\";";
        }
    }
}
