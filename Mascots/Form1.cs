using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mascots
{
    public partial class frmFunny : Form
    {
        public frmFunny()
        {
            InitializeComponent();
        }

        private void magnusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblHeeHee.Text = "He smell like rice";
        }

        private void danielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblHeeHee.Text = "He smell like onion";
        }

        private void maciekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblHeeHee.Text = "he smell like penis";
        }

        private void tongoDrumpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblHeeHee.Text = "he smell like soup";
        }
    }
}
