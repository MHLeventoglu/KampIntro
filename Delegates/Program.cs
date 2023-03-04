

namespace Delegates;

public delegate void MyDelegate(); //Elçilik
public delegate void MyDelegate2(string text);
public delegate int MyDelegate3(int number1, int number2);

class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        Math math = new Math();
        
        MyDelegate myDelegate = customerManager.SendMessage; //Elçi
        myDelegate += customerManager.ShowAlert;
        myDelegate -= customerManager.SendMessage;
        
        MyDelegate2 myDelegate2 = customerManager.SendMessage2;
        myDelegate2 += customerManager.ShowAlert2;
        
        MyDelegate3 myDelegate3 = math.Add;
        myDelegate3 += math.Multiply;
        int result = myDelegate3(11,9);
        Console.WriteLine(result); // Output: 99
                                   // Because last added method works while working with "return"
        
                                   
        Func<int, int, int> add = math.Add;//Func<param,param,out> //"out": return value
        Console.WriteLine(add(2, 4));      //Func<param, out>
        
        Func<int> getRandomNum = delegate() //Func<out>
        {                                   //Here, "Func" can return without parameter method
            Random random = new Random();
            return random.Next(1, 100);
        };
       //We can write both either above and below.
        Func<int> getRandomNum2 = () => new Random().Next(1, 100);
        Console.WriteLine(getRandomNum());
        Console.WriteLine(getRandomNum2());

        myDelegate2("Hello2");
        myDelegate();

    }
}

public class CustomerManager
{
    public void SendMessage()
    {
        Console.WriteLine("Hello");
    }
    public void ShowAlert()
    {
        Console.WriteLine("!!!Be careful!!!");
    }
    public void SendMessage2(string message)
    {
        Console.WriteLine(message);
    }
    public void ShowAlert2(string alert)
    {
        Console.WriteLine(alert);
    }
}

public class Math
{
    public int Add(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    
    public int Multiply(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }
}