using System;

namespace ServiceCallin2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ServiceReference1.Service2Client client = new ServiceReference1.Service2Client();
            Console.WriteLine(client.AddEmployee());

            Console.ReadLine();

        }
    }
}
