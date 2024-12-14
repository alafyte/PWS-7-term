using System;
using System.ServiceModel.Description;
using System.ServiceModel;

namespace ConsoleHost
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (ServiceHost host = new ServiceHost(typeof(Lab05.WCFSimplex)))
            {
                host.Open();

                Console.WriteLine("Service host is running...");

                foreach (ServiceEndpoint sep in host.Description.Endpoints)
                {
                    Console.WriteLine($"  endpoint {sep.Address} ({sep.Binding.Name})");
                }

                Console.ReadLine();

                host.Close();
            }
        }
    }
}
