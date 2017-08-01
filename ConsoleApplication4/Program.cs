using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MaxValue;  // 2147483647

            int min = int.MinValue; // -2147483648

            unchecked
            {

                max += max;

            }
        }
    }
}
