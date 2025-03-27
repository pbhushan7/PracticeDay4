using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RefAndValueTypes
{
    internal class Program
    {
        static void Main()
        {
            // Example for reference type
            Class2 o1 = new Class2();
            Class2 o2 = new Class2();

            o1.i = 1;
            o2.i = 2;
            o2 = o1;
            o2.i = 3;
            Console.WriteLine(o1.i);
            Console.WriteLine(o2.i);
            Console.ReadLine();

        }

        static void Main1()
        {
            // Example of Values
            int o1 , o2 ;
            //o1 = 1;
            o2 = 2;
            o1 = o2;
            o2 = 3;
            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.ReadLine();
        }
        public static void Main3()
        {
            //exception for strig class as it is reference type but works like Value type
            string b1, b2;
            b1 = "100";
            b2 = "200";
            b1 = b2;
            b2 = "300";
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.ReadLine();

        }
        //static void Datatypes()
        //{
        //    // C# DataType -- // CTS (Common type System)

        //    //Value Types
        //    char ch; //Char - 2 bytes
        //    byte b; //1 byte
        //    sbyte b1; //1 Sbyte
        //    short s; //Int16 - 2 bytes
        //    ushort us; //UInt16 - 2 bytes
        //    int i; // Int32 - 4 bytes
        //    uint ui; //UInt32 - 4 bytes
        //    long l; //Int64 - 8 bytes
        //    ulong ul; //UInt64 - 8 bytes
        //    bool bo; //boolean
        //    float f; // Float - 4 bytes  -- Single
        //    double d; // Double - 8 bytes
        //    decimal de; // Decimal - 16bytes

        //    // ReferenceType
        //    string str; //String
        //    object obj; //Object
        //}
        public class Class2
        {
            public int i;
        }

        static void Main4()
        {
            //int i = 12;
            //int j = 13;
            //Swap(i, j);
            //Console.WriteLine(i);
            //Console.WriteLine(j);    // This code will not swap the value for you.

            //int a = 12;
            //int b = 13;
            //init(out a, out b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);  // for swapping the values you need to use ref..

            //int a;
            //int b;
            //init(out a, out b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);   // for initiate the value from method you need to use out..

            int a = 45;
            Print(in a);

            Console.ReadLine();
        }
        static void Swap(ref int i, ref int j)   // i = a, j = b
        {
            int temp = i;
            i = j;
            j = temp;
        }
        static void init(out int i, out int j)
        {
            i = 100;
            j = 200;
        }
        static void Print(in int i)
        {
            Console.WriteLine(i);

            //int i = 100;  -- // Error bcz in keyword is use for ReadOnly
        }

        
    }
}

namespace RefAndValueTypes2
{
    public class Program
    {
        public static void Main()
        {
            Class3 o = new Class3();
            o.i = 10;
            DoSomething1(o);
            //DoSomething2(o);
            //DoSomething3(ref o);
            Console.WriteLine(o.i);
            Console.ReadLine();
        }
        public static void DoSomething1(Class3 Obj) //obj = o
        {
            //Changes made in functions(Changing value of properties) reflecting in calling code o
            Obj.i = 100;
        }
        public static void DoSomething2(Class3 Obj)  // obj = o
        {
            //Changes made in functions(obj pointing to some othor block) is NOT reflecting in calling code o
            Obj.i = 100;
            Obj = new Class3();
            Obj.i = 100;
        }
        public static void DoSomething3(ref Class3 Obj)  //obj = o
        {
            //Changes made in functions(obj pointing to some othor block) is reflecting in calling code o
            Obj = new Class3();
            Obj.i = 100;
        }
    }
    public class Class3
    {
        public int i;
    }

} 


