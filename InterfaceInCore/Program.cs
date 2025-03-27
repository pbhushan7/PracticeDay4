using System;

namespace InterfaceInCore
{
    internal class Program
    {
        static void Main()
        {
            Class1 o = new Class1();
            (o as IDbFumctions).DefaultImp();
        }
    }
    public interface IDbFumctions
    {
        void Insert();
        void Update();
        void Delete();  

        void DefaultImp()
        {
            Console.WriteLine("Method having default Implimentation");    
        }

    }
    public class Class1 : IDbFumctions
    {
        public void Delete()
        {
            Console.WriteLine("Class1 - IDb.Delete");
        }

        public void Insert()
        {
            Console.WriteLine("Class1 - IDb.Insert");
        }

        public void Update()
        {
            Console.WriteLine("Class1 - IDb.Update");
        }
        void IDbFumctions.DefaultImp()
        {
            Console.WriteLine("Class1 - Method for Default implementation");
        }
    }
}
