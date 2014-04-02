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
    public partial class Drops : Form
    {
        public Drops()
        {
            InitializeComponent();
        }

        private void drop_gen_Click(object sender, EventArgs e)
        {
            drop_sql.Text = "INSERT INTO `drops` VALUES ('" + drop_monster.Text + "', '" + drop_item.Text + "', '" + drop_pp.Text + "', '" + drop_max.Text + "', '" + drop_chance.Text + "');";
        }
    }
}
