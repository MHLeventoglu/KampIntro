namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Vladmir Harkonnen";
            customer1.Id = "0000";
            customer1.Loyality = 1;
            customer1.Age = 73;

            Customer customer2 = new Customer();
            customer2.Name = "Paul Muad'Dib";
            customer2.Id = "3527";
            customer2.Loyality = 77;
            customer2.Age = 32;

            Customer customer3 = new Customer();
            customer3.Name = "Leto Atreides";
            customer3.Id = "4891";
            customer3.Loyality = 98;
            customer3.Age = 19;

            Customer[] customers = {customer1,customer2,customer3};
            CustomerManager customerManager = new CustomerManager();

            
            Console.WriteLine("please select and action");
            Console.WriteLine("1 for Add");
            Console.WriteLine("2 for Delete");
            Console.WriteLine("3 for Show customer list");
            Console.WriteLine("////////////////////");

            while (0 == 0)
            {
                int num;
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    customerManager.Add(customer1);
                    customerManager.Add(customer2);
                    customerManager.Add(customer3);
                    Console.WriteLine("---------------");

                }
                else if (num == 2)
                {
                    customerManager.Delete(customer1);
                    customerManager.Delete(customer2);
                    customerManager.Delete(customer3);
                    Console.WriteLine("---------------");

                }
                else if (num == 3)
                {
                    foreach (Customer a in customers)
                    {
                        customerManager.List(a);
                    }

                }
                Console.WriteLine("--If you don't wanna continue, text 'Y'--");
                if (Console.ReadLine() == "N")break ;
            }
        }
   }
}