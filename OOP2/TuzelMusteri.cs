using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Coorporate
    //"TuzelMusteri:Musteri" we call that event as Inheritance(that means "TuzelMusteri" is a "Musteri")
    //internal class TuzelMusteri:Musteri,Calisan -We cannot add more than one inheritance-
    //instead of "inheritance"s, in "interface"s, we can define more than one interface
    internal class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
