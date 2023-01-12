using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class TaksitKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Taksit Kredisi hesaplandı");
        }
    }
}
