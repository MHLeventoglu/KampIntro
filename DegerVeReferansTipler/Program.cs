namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 25;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //Console.WriteLine(sayi1); => 65 would be shown

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // Console.Writeline(sayilar1[0]); => 999 would be shown
            //int,string,bool,double... are valuable types.
            //array,class and interface are referance types.
        }
    }
}