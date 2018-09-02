using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string filePath = @"D:\ArpanBTSS\VSTS\arpan-shah\MarketAnalysis\Analysis\ConsoleApp\Uploads\BSESN.csv";
            
            var service = new Business();
            var csv = new CsvReader();
            var watch = new Stopwatch();
            watch.Start();
            foreach (var items in csv.Reading(filePath, new char[] { ',' },true))
            {
                var value = Math.Round(Convert.ToDecimal(items[4]), 2);
                var list = service.AddValue(value);
                service.ProcessValues(value,list);
            }
            watch.Stop();
            Console.WriteLine($"\n{watch.ElapsedMilliseconds} milliseconds are elapsed for this execution.");
            // Suspend the screen.  
            Console.ReadLine();
        }

        
        
    }
}
