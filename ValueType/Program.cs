using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Structs
namespace ValueType
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int i = new int();
            MyPoint P = new MyPoint();
            Console.WriteLine(P.X);
            Console.ReadLine();
        }
        public struct MyPoint
        {
            public int A { get; set; }
            public int X;
            public int Y;

            public MyPoint(int X =1 , int Y = 0, int A = 0)
            {
                Console.WriteLine("Ctor called");
                this.X = X;
                this.Y = Y; 
                this.A = A;
            }

        }
    }
}

//enums
namespace Valuetype1
{
    public class Program
    {
        public static void Main()
        {
            //Display1(1);
            Display2(timeOfDay.Morning);
            Console.ReadLine();
        }
        public static void Display1(int t)
        {
            if (t == 0) Console.WriteLine("Good Morning");
            else if (t == 1) Console.WriteLine("Good Afternoon");
            else if (t == 2) Console.WriteLine("Good Evevning");
            else if (t == 3) Console.WriteLine("Good Night");
        }
        public static void Display2(timeOfDay t)
        {
            if (t == timeOfDay.Morning)
                Console.WriteLine("Good Morning");
            else if (t == timeOfDay.Evening)
                Console.WriteLine("Good Evevning");
            else if (t == timeOfDay.Afternoon)
                Console.WriteLine("Good Afternoon");
            else if (t == timeOfDay.Night) 
                Console.WriteLine("Good Night");


        }
        public enum timeOfDay // by default it willl take --> public enum timeOfDay :int
        {
            Morning,
            Afternoon,
            Evening,
            Night

        }
    }
    
}


