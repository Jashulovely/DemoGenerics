using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generics<int> generics = new Generics<int>(10);
            Generics<string> genericsString = new Generics<string>("Jashu");
            Generics<bool> genericsBool = new Generics<bool>(true);
            Generics<double> genericsDouble = new Generics<double>(10.9);
            Console.WriteLine();
            generics.DemoMethod(999);
            genericsString.DemoMethod("Kumar");
            genericsBool.DemoMethod(false);
            genericsDouble.DemoMethod(55.55);
            Console.WriteLine();
            Generic generic = new Generic();
            generic.GenericMethod(5);
            generic.GenericMethod("Manoj");
            generic.GenericMethod(true);
            generic.GenericMethod(77.77);
            generic.GenericMethod<int>(5);
            generic.GenericMethod<string>("Manoj");
            generic.GenericMethod<bool>(true);
            generic.GenericMethod<double>(77.77);
            Console.ReadLine();
        }
    }
}
