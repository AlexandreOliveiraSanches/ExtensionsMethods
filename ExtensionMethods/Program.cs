using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Time duraction(dd/MM/yyyy hh:mm): ");
            DateTime dt = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Time duraction: " + dt.ElapsedTime());
            Console.WriteLine("_____________________________________");
            Console.Write("Write something: ");
            string s = Console.ReadLine();
            Console.Write("How many characters should remain in the message? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: " + s.Cut(n));
        }
    }
}