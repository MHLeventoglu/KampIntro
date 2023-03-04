

namespace Events;

public delegate void StockControl();

class Program
{
    static void Main(string[] args)
    {
        Product hardDisk = new Product(50);
        hardDisk.ProductName = "Hard Disk";

        Product gsm = new Product(50);
        gsm.ProductName = "GSM";
        gsm.StockControlEvent += Gsm_StockControlEvent;

        for (int i = 0; i < 5; i++)
        {
            hardDisk.Sell(10);
            gsm.Sell(10);
            Console.ReadLine();
        }
    }

    private static void Gsm_StockControlEvent()
    {
        Console.WriteLine("Gsm about to finish!!!");
    }
}
public class Product
{
    private int _stock;

    public Product(int stock)
    {
        _stock = stock;
    }

    public event StockControl StockControlEvent;
    public string ProductName { get; set; }

    public int Stock
    {
        get => _stock; // get { return _stock; }
        set
        {
            _stock = value;
            if (value<=15 && StockControlEvent!=null)//If we don't check is "Event" null, programme crashes because of "Hard Disk" doesn't have "Event"
            {
                StockControlEvent();
            }
        }
    }

    public void Sell(int amount)
    {
        Stock -= amount;
        Console.WriteLine("{1} -> Stock amount : {0} ",Stock,ProductName);
    }
}