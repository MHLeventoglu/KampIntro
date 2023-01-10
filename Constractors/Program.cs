namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    Customer customer1 = new Customer();
        //    customer1.Id = "123";
        //    customer1.FirstName = "Muaz";
        //    customer1.LastName = "Leventoğlu";

        //    Customer customer2 = new Customer(Id="234", FirstName="Hamza", LastName="Lavantagül");

            Customer customer3 = new Customer("345","Engin","Demiroğ");

            Console.WriteLine(customer3.Id);
        }
    }

    class Customer
    {
        public Customer()//Constructor2
        {
            
        }

        public Customer(string id, string firstName, string lastName)//Constructor 1
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;    
        }

        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}