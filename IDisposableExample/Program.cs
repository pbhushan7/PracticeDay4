using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposableExample
{
    internal class Program
    {
        static void Main()
        {
            //Class1 o1 = new Class1();
            using (Class1 o1 = new Class1())
            {
                o1.Display1();
            }
            //here automatically dispose method gets called
            Class1 o2 = new Class1();
            o2.Display1();
            Console.ReadLine();
        }
        static void Main1()
        {
            Class2 o2 = new Class2();
            o2.Display();
            o2.Dispose();
            o2.Display();
            Console.ReadLine();
        }
    }
    public class Class1 : IDisposable
    {
        public Class1()
        {
            //Open File
            //Open DB
            Console.WriteLine("Called Constructor");
        }
        public void Display()
        {
            Console.WriteLine("Display");
        }
        public void Display1()
        {
            Console.WriteLine("Display1");
        }
        public void Dispose()
        {
            //Close file
            //close DB
            Console.WriteLine("Disposed code called. Write code here instead of Destructor");
        }
    }

    public class Class2 : IDisposable
    {
        public Class2()
        {
            //Open File
            //Open DB
            Console.WriteLine("Called Constructor");
        }
        bool isDisposed;
        public void Display()
        {
            CheckForDisposed1();
            Console.WriteLine("Display");
        }

        public void Dispose()
        {
            CheckForDisposed1();
            //Close file
            //close DB
            Console.WriteLine("Disposed code called. Write code here instead of Destructor");
            isDisposed = true;
        }

        private void CheckForDisposed1()
        {
            if (isDisposed)
                throw new ObjectDisposedException("Class2");
        }
    }
}
