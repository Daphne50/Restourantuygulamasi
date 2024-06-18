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
    public partial class Frmsiparis : Form
    {
        public Frmsiparis()
        {
            InitializeComponent();
        }

        private void Frmsiparis_Load(object sender, EventArgs e)
        {
            foreach (salon salon in salon.Salonlar)
            {
                flowLayoutPanel1.Controls.Add(salon);
                salon.Click += Salon_Click;
            }
        }

        private void Salon_Click(object sender, EventArgs e)
        {
            salon s = (salon)sender;
            frmmasalistele ms1 = new frmmasalistele();
            ms1.MdiParent = this.MdiParent;
            ms1.Salon = s;
            ms1.Show();


        }

        private void Frmsiparis_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Controls.Clear();
        }
    }
}
