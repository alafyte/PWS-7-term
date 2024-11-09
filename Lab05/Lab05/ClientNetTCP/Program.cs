using System;

namespace ClientNetTCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lab05.A a = new Lab05.A(), b = new Lab05.A();
            a.f = 3.1f; b.f = 28.6f;
            a.k = 23; b.k = -2;
            a.s = "ab"; b.s = "ba";

            WCFSimplexClient client = new WCFSimplexClient();

            Console.WriteLine(client.Add(78, 23));
            Console.WriteLine(client.Concat("Hello, ", "World!"));

            Lab05.A result = client.Sum(a, b);
            Console.WriteLine($"f: {result.f}\nk: {result.k}\ns: {result.s}");

            client.Close();
        }
    }
}
