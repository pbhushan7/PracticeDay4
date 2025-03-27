using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes  
    // NullableType is ValueType that converted to allow nulls.
{
    internal class Program
    {
        static void Main()
        {
            int? i;
            i = 10;
            i = null;
            //short? s;
            //decimal? d;
            int k;
            k = (int)i;
            Console.WriteLine(k);



            int j;
            if (i != null)
            {
                j = (int)i;
            }
            else j = 0;
             
            //
            if (i.HasValue)
                j = i.Value;
            else j = 0;

            // if I has any value it will rpint orlse it will print default value i.e. 0
            j = i.GetValueOrDefault(); 
            //heree i value is 10 so will print i
            j = i.GetValueOrDefault(10);

            //
            j = i ?? 10;   // Null Coalescing operator


            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
