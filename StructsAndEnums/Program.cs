#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            // Month first = Month.December;
            // Console.WriteLine(first);
            // first++;
            // Console.WriteLine(first);

            //Date defaultDate = new Date();
            //Console.WriteLine(defaultDate);

            Date weddingAnniversary = new Date(2015, Month.July, 4);
            Console.WriteLine(weddingAnniversary);

            Date weddingAnniveraryCopy = weddingAnniversary;
            Console.WriteLine($"Value of copy is {weddingAnniveraryCopy}");

            weddingAnniversary.AdvanceMonth();
            Console.WriteLine($"New value of weddingAnniversary is {weddingAnniversary}");
            Console.WriteLine($"Value of copy is still {weddingAnniveraryCopy}");
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
