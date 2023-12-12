using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAR
{
    public class ClassVar
    {
        public void function()
        {
            int[] numbers = { 1, 2, 3, 654, 5, 6, 257, 8, 9 };
            var result = from i in numbers where i > 15 select i;

            foreach (var item in result)
            {
                Console.WriteLine($"{item}\t");
            }

            Console.WriteLine();

            Console.WriteLine($"Type data result:  {result.GetType()} ");
        }
    }
}
    
