using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
 public    class masa:Button
    {

        public masa()
        {
            this.Width = 70;
            this.Height = 70;

        }
     public string _kodu;
        public string kodu
        {
            get { return _kodu; }
            set { _kodu =this.Text=value; }
        }


     private  string _MusteriAdi;
        public string MusteriAdi
        {
            get { return _MusteriAdi; }

            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("İsim 3 harften küçük olamaz");
                   

                    _MusteriAdi = value;
                }
            }

        }
        public string _MusteriTelefon;
        public string MusteriTelefon
        {
            get { return _MusteriTelefon; }
            set {
                if (value.Length < 7 && value.Length > 0) {
                    throw new Exception("Yanlış Girilen Telefon Numarası");
                

                }
                _MusteriTelefon = value; }
        }
        public bool rezerve = false;
        public bool Dolu = false;
       // public decimal Tutar = 0;
        List<urun> _Urunler = new List<urun>();
        public List<urun> Urunler
        {
            get { return _Urunler; }
            set { _Urunler = value; }
        }
        public decimal Tutar
        {
            get
            {
                decimal s = 0;
                foreach (urun u in Urunler)
                {
                    s += u.Fiyat;
                }
                return s;
            }
           
        }
    }
}
