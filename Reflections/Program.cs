// One of usage of Reflections is determine when a method will be used (Before, in Process or After executing)
//
//

using System.Reflection;

namespace Reflections;

class Program
{
    static void Main(string[] args)
    {
        // DortIslem dortIslem = new DortIslem(2, 3);
        // dortIslem.Topla2();
        // dortIslem.Topla(3, 4);    
        
        var type = typeof(DortIslem); // DortIslem as a parameter.
        //var dortIslem = Activator.CreateInstance(type); //Activator means do it when program is ran.
        //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,6,7)!;//Yes, "type" consist of only "DortIslem" type but "Activator.CreateInstance" returns Object type. Because of that we have to specify this is (DortIslem)
        // dortIslem.Topla(2, 3);// We have to create non parameter ctor for tha
        // dortIslem.Topla2();

        var instance = Activator.CreateInstance(type, 6, 7);
        // instance.GetType().GetMethod("Topla2").Invoke(instance,null); //It's like execute it like it's a method of which instance.
        MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
        Console.WriteLine(methodInfo.Invoke(instance,null));
        Console.WriteLine("--------------------");
        
        var methods = type.GetMethods();

        foreach (var info in methods)
        {
            Console.WriteLine("Metod adı: {0}",info.Name);
            foreach (var parameterInfo in info.GetParameters())
            {
                Console.WriteLine("Parametre : {0}",parameterInfo.Name);
            }

            foreach (var attribute in info.GetCustomAttributes())
            {
                Console.WriteLine("Attribute : {0}",attribute.GetType().Name);
            }
        }


        
    }

    class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public DortIslem()
        {
            
        }

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        [MethodName("Carpma")]
        public int Carp(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        
        [MethodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {
            
        }
    }
}
