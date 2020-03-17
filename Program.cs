using System;
using System.IO;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            string writetext = "Hello world!";
            File.WriteAllText("fileNaam.txt", writetext);

            string readText = File.ReadAllText("fileNaam.txt");
            Console.WriteLine(readText);
            Console.ReadLine();
        }
    }
}
