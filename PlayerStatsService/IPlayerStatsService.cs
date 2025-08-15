using System.Runtime.Serialization;
using System.ServiceModel;

namespace PlayerStatsService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPlayerStatsService
    {

        [OperationContract]
        string GetPlayerName(int playerId);
        [OperationContract]
        PlayerStatistics GetPlayerStats(int playerId);
    }

    [DataContract]
    public class PlayerStatistics
    {
        [DataMember]
        public int Points { get; set; }
        [DataMember]
        public int Rank { get; set; }
    }
}
