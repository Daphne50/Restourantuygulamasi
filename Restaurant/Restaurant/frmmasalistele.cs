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
    public partial class frmmasalistele : Form
    {
        public frmmasalistele()
        {
            InitializeComponent();
        }

        public salon Salon { get; set; }

        private void frmmasalistele_Load(object sender, EventArgs e)
        {


            lblsalonadi.Text = Salon.Adi;
            foreach (masa masa in Salon.Masalar)
            {
                masa.Click += Masa_Click;
                flowLayoutPanel1.Controls.Add(masa);
            }
        }

        private void Masa_Click(object sender, EventArgs e)
        {

            frmmasadetay mdf = new frmmasadetay();
            mdf.Masa = (masa)sender;
            mdf.MdiParent = this.MdiParent;
            mdf.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
