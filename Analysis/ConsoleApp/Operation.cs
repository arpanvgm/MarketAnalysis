using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Operation
    {
        public void PrintDiffrence(decimal current,decimal[] lastValues)
        {
            Console.WriteLine();
            Console.Write(current);
            var i = 0;
            while (i < lastValues.Length && lastValues[i] > 0M)
            {
                var percentage = Math.Round((100 * (current - lastValues[i])) / lastValues[i], 2);
                Console.Write(" {0,8}", percentage);
                i++;
            }
        }

       

    }
}
