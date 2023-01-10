using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler = new string[5]; 
            //isimler haricinde yeni bir ilk 4 elemanı boş bir 5 elemanlı array oluşturduk(aynı zamanda farklı bir bellekte)
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);// bu sebeple ilk elemana geri dönemedik.
            Console.WriteLine("VVV'List/Koleksiyon yöntemiyle'VVV");
           ////////////////////////////////////////////////////////////////////////////
           List<string> isimler2 = new List<string>();
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            Console.WriteLine("VVV'List metodu olmasaydı aşağıdakini yapardık'VVV");


        }
    }
}