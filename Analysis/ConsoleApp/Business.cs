using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Business
    {
        public Business()
        {
            this.AddValue = new Store<decimal>(6).AddValue;
            this.ProcessValues = new Operation().PrintDiffrence;
        }

        public Func<decimal, decimal[]> AddValue = (value) => { return new decimal[] { value }; };
        public Action<decimal, decimal[]> ProcessValues = (current, values) =>
        {
            Console.WriteLine();
            Console.Write(current);
            var i = 0;
            while (i < values.Length && values[i] > 0M)
            {
                Console.Write($" {values[i]}");
                i++;
            }
        };

    }
}
