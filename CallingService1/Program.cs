using System;

namespace CallingService1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client service1Client = new ServiceReference1.Service1Client();
            Console.WriteLine(service1Client.GetData());
            Console.Read();
        }
    }
}
