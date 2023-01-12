namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            KonutKrediManager konutKrediManager1 = new KonutKrediManager();
            TaksitKrediManager taksitKrediManager1 = new TaksitKrediManager();
            //ihtiyacKrediManager1.Hesapla();
            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager1, dataBaseLoggerService);
            basvuruManager.BasvuruYap(konutKrediManager1, new DataBaseLoggerService()) ;
            basvuruManager.BasvuruYap(taksitKrediManager1, new FileLoggerService());
            
            Console.WriteLine("\nVVVVVVVVbir de bu şekilde deneyelimVVVVVVVV\n");
            
            List<IKrediManager> krediler = new List<IKrediManager>() {taksitKrediManager1, konutKrediManager1 };
            //basvuruManager.KrediOnBilgilendirme(krediler);

        }
    }
}