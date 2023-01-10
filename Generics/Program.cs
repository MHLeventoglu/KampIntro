namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> sehirler = new MyList<string>();
            sehirler.Add("ankara");
            sehirler.Add("istanbul");
            sehirler.Add("kayseri");
            Console.WriteLine("listede "+sehirler.Count+" sehir bulunmaktadır");
            Console.WriteLine(sehirler.Sehirler[0]);

            foreach (string item in sehirler.Sehirler)
            {
                Console.WriteLine(item);
            }
        }

        class MyList<T>
        {
            T[] _array;
            T[] _tempArray;


            public MyList()
            {
                _array = new T[0];
            }
            public void Add(T item)
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1];
                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }
                _array[_array.Length-1] = item;

            }
            public T[] Sehirler
            {
                get { return _array; }
            }

            public int Count
            {
                get { return _array.Length; }
            }
        }
        
    }
}