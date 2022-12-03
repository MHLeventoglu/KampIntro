using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"phyton", "c", "c++", "c#", "java" };
            
            Console.WriteLine("  for döngüsü");
            Console.WriteLine("      VVV    ");

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine("{0}) {1}",i+1,kurslar[i]);
            }

            Console.WriteLine("foreach döngüsü");
            Console.WriteLine("      VVV      ");


            foreach (string kurs in kurslar)
            {
                int a = 1;
                Console.WriteLine("{0}) {1}",a++,kurs);   
            }
        }
    }
}