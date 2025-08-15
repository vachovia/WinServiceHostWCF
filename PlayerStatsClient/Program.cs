using PlayerStatsClient.PlayerStatsRef;
using System;

namespace PlayerStatsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Step 1: Create an instance of the WCF proxy.
            PlayerStatsServiceClient client = new PlayerStatsServiceClient();
            
            var name = client.GetPlayerName(5);
            var stats = client.GetPlayerStats(5);

            Console.WriteLine("Name({0},{1}) = {2}", name, stats.Points, stats.Rank);

            Console.WriteLine("\nPress <Enter> to terminate the client.");
            Console.ReadLine();
            client.Close();
        }
    }
}
