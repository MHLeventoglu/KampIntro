using System;
using System.Numerics;
using System.Text;
namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya elması";
            urun1.Fiyati = 7.5;

            Urun urun2 = new Urun();
            urun2.Adi = "Kayısı";
            urun2.Aciklama = "Malatya kayısı ";
            urun2.Fiyati = 9.25;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün: "+urun.Adi);
                Console.WriteLine("Açıklama: "+urun.Aciklama);
                Console.WriteLine("Fiyat: "+urun.Fiyati);
                Console.WriteLine("//////////////////////////");

            }
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);

            sepetManager.Ekle2("armut","yeşil",5.35); 
        }
    }
}