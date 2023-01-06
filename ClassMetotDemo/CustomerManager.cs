using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add (Customer addCustomer)
        {
            Console.WriteLine("Customer named '{0}' successfully added" ,addCustomer.Name);
        }
        public void Delete(Customer deleteCustomer)
        {
            Console.WriteLine("Customer named '{0}' successfully deleted", deleteCustomer.Name);
        }
        public void List(Customer listCustomer)
        {
            Console.WriteLine("Name: {0}\nId: {1}\nLoyality rate: {2}%\n---------", listCustomer.Name, listCustomer.Id, listCustomer.Loyality);
        }
    }
}
