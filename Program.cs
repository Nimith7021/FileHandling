using FileHandling.Models;
namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleUser user = new ConsoleUser();
            HtmlHandling htmlHandling = new HtmlHandling();


            Console.WriteLine("Enter the username to append to file");
            string username = Console.ReadLine();
            user.ConsoleUsernameAppend(username); //function will append the username 


            string data = File.ReadAllText
                (@"C:\Users\nimith.shetty\Desktop\AproSCM\FileHandling\Assets\sample.txt");
            Console.WriteLine(data);
            string write = Console.ReadLine();
            File.WriteAllText
                (@"C:\Users\nimith.shetty\Desktop\AproSCM\FileHandling\Assets\sample.txt", write);

            Console.WriteLine("Enter your html code to append");
            string htmlData = Console.ReadLine();


            htmlHandling.HtmlFileUpdate(htmlData);
        }

        
       
    }
}
