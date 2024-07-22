using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Models
{
    internal class HtmlHandling
    {
        public void HtmlFileUpdate(string data)
        {
            string path = @"C:\Users\nimith.shetty\Desktop\AproSCM\FileHandling\Assets\intro.html";
            using (StreamWriter sw = new StreamWriter(path, true))
            {

                sw.WriteLine(data);
                Console.WriteLine("Tags written");

            }

            using (StreamReader sr = new StreamReader(path))
            {

                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
