using System;
using System.IO; 

namespace SystemInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== THONG TIN HE THONG ===");

            
            OperatingSystem os = Environment.OSVersion;
            Console.WriteLine($"Phien ban HDH: {os.VersionString}");
            Console.WriteLine($"Nen tang: {os.Platform}");

            
            string currentDir = Directory.GetCurrentDirectory();
            Console.WriteLine($"Thu muc hien tai: {currentDir}");

            
            DateTime now = DateTime.Now;
            Console.WriteLine($"Thoi gian he thong: {now.ToString("dd/MM/yyyy HH:mm:ss")}");

            Console.ReadKey();
        }
    }
}