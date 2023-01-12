using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            // KonutKrediManager konutkrediManager = new KonutKrediManager();
            // konutkrediManager.Hesapla();
            // Eğer bunu üstteki şekilde yazsaydık tüm başvuru işlemleri Konut Kredisine bağımlı kalacaktı//
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirme(List<IKrediManager> krediler)
        {
            foreach (IKrediManager kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
