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
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Les ID des réponses possibles doivent être présentés ainsi :\n"
             +"[ID_Réponse_1];[ID_Réponse_2];\n"
             +"Vous pouvez mettre au plus 5 réponses pour une question.\n"
             +"Il est possible de ne mettre qu'une seule réponse.",
             "ID Réponses",
             MessageBoxButtons.OK,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Les params sont des colonnes encore jamais trop utilisée, elle servent pour le prix de la banque en rentrant cette valeur :\n"
             + "[bankCost]\n"
             + "Si vous ne savez pas l'utiliser, laisser cette case vide.\n",
             "Params",
             MessageBoxButtons.OK,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Les conditions permettent d'afficher la question que si les conditions sont remplies.\n"
             + "Vous pouvez voir la liste des conditions dans l'onglet en haut de nEditor.\n"
             + "Laissez la case vide si vous ne voulez pas de condition.\n",
             "Condition(s)",
             MessageBoxButtons.OK,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ce champ est à remplir en cas de conditions. C'est la question qui sera renvoyée si les conditions ne sont pas remplies.\n"
             + "Laissez la case vide si vous n'avez pas de condition.\n",
             "ifFalse",
             MessageBoxButtons.OK,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button1);
        }

        private void question_gen_Click(object sender, EventArgs e)
        {
            question_sql.Text = "D.q[" + question_id.Text + "] = \"" + question_text.Text + "\";";
            question_swf.Text = "INSERT INTO `npc_questions` VALUES ('" + question_id.Text + "', '" + question_reponses.Text + "', '" + question_params.Text + "', '" + question_conds.Text + "', '" + question_iffalse.Text + "');";
        }

        private void Questions_Load(object sender, EventArgs e)
        {

        }
    }
}
