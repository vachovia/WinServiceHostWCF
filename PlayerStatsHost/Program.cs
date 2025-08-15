using System;
using System.ServiceModel;

namespace PlayerStatsHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(PlayerStatsService.PlayerStatsService));
            host.Open();

            Console.WriteLine("Host started @ " + DateTime.Now.ToString());
            Console.ReadLine();
        }
    }
}
