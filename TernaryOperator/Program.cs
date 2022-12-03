namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "", password = "";
            Console.WriteLine("Username&Password:");
            username = Console.ReadLine();
            password = Console.ReadLine();
            //With if & else//
            // if (username == "admin" && password == "4424")
            // {
            //     Console.WriteLine("log in successful :D");
            // }
            // else
            // {
            //     Console.WriteLine("!!!wrong username or password!!!");
            // }
            
            //With TernaryOperator//
            string status = (username == "admin" && password == "4424")? "log in successful :D" : "!!!wrong username or password!!!";
                Console.WriteLine(status);
                
            
        }
    }
}