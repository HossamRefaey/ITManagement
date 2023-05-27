using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Othaim_Management.Views;

namespace Othaim_Management.Views
{
    public partial class frm_Mainold : Form
    {
        public frm_Mainold()
        {
            InitializeComponent();
        }

        private void branchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Branch frm = new frm_Branch();
            frm.ShowDialog();
        }

        private void categoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void deviceTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //frm_Categoryold frm = new frm_Categoryold();
            //frm.ShowDialog();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //frm_DevType frm = new frm_DevType();
            //frm.ShowDialog();

        }

        private void dBConnictionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void الأجهزةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Item frm = new frm_Add_Item();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frm_DevModel frm = new frm_DevModel();
            //frm.ShowDialog();
        }

        private void تكويدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CodeGeneration frm = new frm_CodeGeneration();
            frm.ShowDialog();
        }
    }
}
