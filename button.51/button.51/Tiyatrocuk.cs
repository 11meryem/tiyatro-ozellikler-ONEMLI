using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace button._51
{
    internal class Tiyatrocuk
    {
        int id;
        string ad;
        DateTime tarih;
        decimal sure;
        string sahne;
        bool muzikal;
        double fiyat;

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public decimal Sure { get => sure; set => sure = value; }
        public string Sahne { get => sahne; set => sahne = value; }
        public bool Muzikal { get => muzikal; set => muzikal = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }

        public Tiyatrocuk(int id, string ad, DateTime tarih, decimal sure, string sahne, bool muzikal, double fiyat)
        {
            this.id = id;
            this.ad = ad;
            this.tarih = tarih;
            this.sure = sure;
            this.sahne = sahne;
            this.muzikal = muzikal;
            this.fiyat = fiyat;

        }
    }
}
