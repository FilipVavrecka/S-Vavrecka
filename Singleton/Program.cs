using System;

namespace Singleton1
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance;
            singleton1.ShowMessage();

            Singleton singleton2 = Singleton.Instance;
            singleton2.ShowMessage();

            Console.WriteLine(Object.ReferenceEquals(singleton1, singleton2) ? "Stejne" : "Jine");
        }
    }
}