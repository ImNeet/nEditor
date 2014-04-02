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
    public partial class Monstres : Form
    {
        public Monstres()
        {
            InitializeComponent();
        }

        private void madd_Click(object sender, EventArgs e)
        {
            msf.Text += msid.Text + "@" + msl.Text + ";";
        }

        private void mgen_Click(object sender, EventArgs e)
        {
            msql.Text = "DELETE FROM monsters WHERE id=" + mid.Text + ";\n"
                        + "INSERT INTO `monsters` VALUES ('" + mid.Text + "','" + mname.Text + "','" + mgfx.Text + "','-1','" + mlvl.Text + "@" + mrn.Text + ";" + mrt.Text + ";" + mrf.Text + ";" + mre.Text + ";" + mra.Text + ";" + mepa.Text + ";" + mepm.Text + "','-1,-1,-1','" + ms.Text + "," + mf.Text + "," + mi.Text + "," + mc.Text + "," + ma.Text + "','" + msf.Text + "','" + mv.Text + "','" + mpa.Text + ";" + mpm.Text + "','1500','" + mkmin.Text + "','" + mkmax.Text + "','" + mexp.Text + "','1','1');";
            mswf.Text = "M[" + mid.Text + "] = {g1: {r: [" + mrn.Text + "," + mrt.Text + "," + mrf.Text + "," + mre.Text + "," + mra.Text + ", " + mepa.Text + ", " + mepm.Text + "], l: " + mlvl.Text + "}, k: false, a: -1, b:2, g: " + mgfx.Text + ", n: \"" + mname.Text + "\"};";
        }
    }
}