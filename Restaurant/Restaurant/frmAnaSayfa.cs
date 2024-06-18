using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
              FrmÜrünler frm = new FrmÜrünler();
            frm.MdiParent=this;
            frm.Show();

        }

        private void salonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsalon frm= new frmsalon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void siparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmsiparis frm = new Frmsiparis();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
