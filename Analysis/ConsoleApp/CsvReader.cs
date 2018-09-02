using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class CsvReader
    {
       
        public CsvReader()
        {
           
        }
        
        public IEnumerable<string[]> Reading(string strPath, char[] separator,bool SkipFirstLine)
        {
            using (var file = new StreamReader(strPath))
            {
                string line;
                if(SkipFirstLine)
                    file.ReadLine();
                while ((line = file.ReadLine()) != null)
                {
                    yield return line.Split(separator);
                }
                file.Close();
            }
        }
    }
}
