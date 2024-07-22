using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Models
{
    internal class ConsoleUser
    {
        public void ConsoleUsernameAppend(string username)
        {
            using (StreamWriter writer = File.AppendText
                (@"C:\Users\nimith.shetty\Desktop\AproSCM\FileHandling\Assets\username.txt"))
            {

                
                writer.WriteLine(username);

            }
        }
    }
}
