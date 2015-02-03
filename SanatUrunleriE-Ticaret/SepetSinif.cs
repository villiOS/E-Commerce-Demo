using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SanatUrunleriE_Ticaret
{
    public class SepetSinif
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public string UrunResim { get; set; }
        public double BirimFiyat { get; set; }
        public double Tutar { get; set; }
        public int Adet { get; set; }

    }
}