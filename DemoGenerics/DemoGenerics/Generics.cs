using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenerics
{
    //Generics means general form 
    //It does not specify a particular type
    //Generic allow us to a single class or method that can be used for different data types.
    // <T> with type parameter
    // type parameter 
    internal class Generics <T>
    {
        //public string data;
        public T data;
        public Generics(T data)
        {
            this.data = data;
            Console.WriteLine(this.data);
        }
        public void DemoMethod(T data)
        {
            Console.WriteLine(data);
        }
    }
    public class Generic
    {
        public void GenericMethod<T>(T info)
        {
            Console.WriteLine(info);
        }
    }
}
