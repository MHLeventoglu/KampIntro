using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Individual
    //"GercekMusteri:Musteri" we call that event as Inheritance(that means "GercekMusteri" is a "Musteri")
    //internal class TuzelMusteri:Musteri,Calisan -We cannot add more than one inheritance-
    //instead of "inheritance"s, in "interface"s, we can define more than one interface
    internal class GercekMusteri:Musteri
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
