using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurant
{
    public class salon : Button
    {
        public salon(string adi, int masaSayisi, string masaOnEk)
        {
            Adi = adi;
            OnEk = masaOnEk;

            for (int i = 0; i < masaSayisi; i++) // Döngüyü 0'dan başlatıyoruz
            {
                masa m = new masa();
                m.kodu = String.Format("{0}{1}", masaOnEk, i + 1); // Kodlama 1'den başlasın
                this.Masalar.Add(m);
            }

            this.Text = adi;
            this.Width = 100;
            this.Height = 100;
        }

        public string Adi { get; set; }
        public string OnEk { get; set; }
        private List<masa> _masalar = new List<masa>();
        public List<masa> Masalar
        {
            get { return _masalar; }
            set { _masalar = value; }
        }

        private static List<salon> _Salonlar = new List<salon>();
        public static List<salon> Salonlar
        {
            get { return salon._Salonlar; }
            set { salon._Salonlar = value; }
        }

        public ListViewItem listolustur()
        {
            ListViewItem li = new ListViewItem();
            li.Text = Adi;
            li.SubItems.Add(Masalar.Count.ToString());
            li.SubItems.Add(OnEk);
            return li;
        }
    }
}
