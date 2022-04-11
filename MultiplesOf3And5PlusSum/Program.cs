using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3And5PlusSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int counter = 1; counter <= 1000; counter++)
            {
                if (counter % 3 == 0 || counter % 5 == 0)
                {
                    sum += counter;
                }
            }

            Console.WriteLine(sum);
        }//end main
    }//end class
}//end namespace
