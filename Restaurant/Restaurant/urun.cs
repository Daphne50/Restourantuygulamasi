using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Restaurant
{
    public class urun
    {
        public urun()
        {
            
        }

        public urun(string adi, decimal fiyat)
        {
            Adi = adi;
            Fiyat = fiyat;

            
            if (Liste.FirstOrDefault(item => item.Adi == adi && item.Fiyat == fiyat) != null)
            {
                Liste.Add(this);
            }
        }

        public string Adi { get; set; }
        public decimal Fiyat { get; set; }

        public virtual ListViewItem listolustur()
        {
            ListViewItem li = new ListViewItem();
            li.Text = Adi;
            li.SubItems.Add(Fiyat.ToString("C2"));
            return li;
        }

        public override string ToString()
        {
            return Adi;
        }

        public static List<urun> Liste = new List<urun>();

        public class EssantiyonUrun : urun
        {
            public EssantiyonUrun()
            {
                
            }

            public override ListViewItem listolustur()
            {
                ListViewItem li = new ListViewItem();
                li.Text = Adi;
                return li;
            }
        }
    }
}
