using System;

namespace ClassIntro
{
    class ClassIntro
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Muaz Hamza";
            kurs2.IzlenmeOrani = 38;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Kağan Kodyazan";
            kurs3.IzlenmeOrani = 47;


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kurs:{0}\nEğitmen:{1}\nİzlenme:%{2}\n///////////////"
                                             ,kurs.KursAdi,kurs.Egitmen,kurs.IzlenmeOrani);

            }
        }
    }

    class Kurs
    {
        public string KursAdi   { get; set; }
        public string Egitmen   { get; set; }
        public int IzlenmeOrani { get; set; } 
    }
}