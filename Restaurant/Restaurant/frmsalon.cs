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
    public partial class frmsalon : Form
    {
        public frmsalon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salon s = new salon(TxtAdi.Text, (int)numMasaSayisi.Value, TxtMasaOnEk.Text); ;
            //   s.Adi = TxtAdi.Text;
            salon.Salonlar.Add(s);
            listView1.Items.Add(s.listolustur());
            

           


        }

        private void numMasaSayisi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmsalon_Load(object sender, EventArgs e)
        {

        }
    }
}
