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
    public partial class frmmasadetay : Form
    {
        public masa Masa { get; set; }

        public frmmasadetay()
        {
            InitializeComponent();
        }

        private void frmmasadetay_Load(object sender, EventArgs e)
        {
            lblmasano.Text = Masa.kodu;
            GuncelleToplamTutar(); // Form yüklenirken toplam tutarı göster
            foreach (urun urun in Masa.Urunler)
            {
                listView1.Items.Add(urun.listolustur());
            }
            combourun.DataSource = urun.Liste;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            urun u = (urun)combourun.SelectedItem;
            Masa.Urunler.Add(u);
            listView1.Items.Add(u.listolustur());
            GuncelleToplamTutar(); 
        }

        private void combourun_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Lbltoplamtutar_Click(object sender, EventArgs e)
        {
           
        }

        private void GuncelleToplamTutar()
        {
            decimal toplamTutar = Masa.Urunler.Sum(u => u.Fiyat);
            Lbltoplamtutar.Text = toplamTutar.ToString("C2");
        }
    }
}
