


namespace Attributes;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer { Id = 1, LastName = "Demiroğ", Age = 32 };
        CustomerDal customerDal = new CustomerDal();
        customerDal.Add(customer);
        Console.ReadKey();
    }

    [ToTable("Customers")]
    // We can convert "Customer" objects to "Customers" table with like attribute
    class Customer
    {
        [RequiredProperty]
        public int Id { get; set; }
        [RequiredProperty]
        public string? FirstName { get; set; }
        [RequiredProperty]
        public string? LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("!!!Don't use that old method, instead use AddNew method!!!")]
        // There are Attributes already exist like "Obsolete".
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!"
                ,customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!"
                ,customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }
    }

    // Custom Attributes can be created this way.
    [AttributeUsage(AttributeTargets.Class)]
    class ToTableAttribute : Attribute
    {
        // private string _tableName;
        public ToTableAttribute(string tableName)
        {
            // _tableName = tableName;
        }
    }
    
    [AttributeUsage(AttributeTargets.Property,AllowMultiple = true)]//Attribute abilities can be limited with [AttributeUsage(...)]
    //AttributeTargets - for filtering target objects
    //AllowMultiple - for determine how much times we can use it in an unique object
    class RequiredPropertyAttribute : Attribute
    {
       
    }
}