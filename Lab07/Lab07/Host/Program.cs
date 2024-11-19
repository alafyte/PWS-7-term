using System;
using System.ServiceModel.Web;

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebServiceHost host = new WebServiceHost(typeof(SyndicationServiceLibrary.Feed));
            host.Open();
            Console.WriteLine("Host is opened.");
            string s = Console.ReadLine();
        }
    }
}
