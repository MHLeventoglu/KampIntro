using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Musteri
    {
        //!!!HATALI KULLANIM!!!
        //Soyutlama hatası
        public int Id { get; set; }
        public string MusteriNo { get; set; }

        //public string Adi { get; set; }
        //public string Soyadi { get; set; }
        //public string SirketAdi { get; set; }
        //public string TcNo { get; set; }
        //public string VergiNo { get; set; }

        //Bu hatalım kullanım gerçek(kişi)müşteri ve tüzel(şirket)müşterilerle ilgili karışıklıklara dolayısıyla BUGlara sebep olabilir.
        //!1!"GerçekMusteri" ve "TuzelMusteri" isimli iki farklı class açılmalı!!!
    }
}
