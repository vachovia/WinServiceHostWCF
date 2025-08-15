namespace PlayerStatsService
{
    public class PlayerStatsService : IPlayerStatsService
    {
        public string GetPlayerName(int playerId)
        {
            // connect to db to get Player e.g.
            return string.Format("You entered: {0}", playerId);
        }

        public PlayerStatistics GetPlayerStats(int playerId)
        {
            return new PlayerStatistics { Points = 9932, Rank = 33 };
        }
    }
}
