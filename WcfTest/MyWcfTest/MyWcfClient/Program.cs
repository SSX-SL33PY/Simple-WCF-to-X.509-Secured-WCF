using System;

namespace MyWcfTest.MyWcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new DoSomethingRemoteClient();

            Console.WriteLine(client.GetMessage("Mickey Mouse"));
            Console.ReadLine();
        }
    }
}
