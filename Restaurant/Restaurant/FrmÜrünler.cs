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
    public partial class FrmÜrünler : Form
    {
        public FrmÜrünler()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
         
          

            urun u = new urun(txtadi.Text,numericfiyat.Value);
            /*u.Adi = txtadi.Text;
            u.Fiyat = numericfiyat.Value;*/

            urun.Liste.Add(u);
            lssturunler.Items.Add(u.listolustur());


             
            


        }

        private void FrmÜrünler_Load(object sender, EventArgs e)
        {

        }
    }
}
