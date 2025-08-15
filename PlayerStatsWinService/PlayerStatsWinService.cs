using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace PlayerStatsWinService
{
    public partial class PlayerStatsWinService : ServiceBase
    {
        ServiceHost host;

        public PlayerStatsWinService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(PlayerStatsService.PlayerStatsService));
            host.Open();
        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
// installutil -i "C:\Development\Playground\ProjectsStorage\Projects\WCF\WindowsHostWcf\WinServiceHostWCF\PlayerStatsWinService\bin\Debug\PlayerStatsWinService.exe"
// installutil -u "C:\Development\Playground\ProjectsStorage\Projects\WCF\WindowsHostWcf\WinServiceHostWCF\PlayerStatsWinService\bin\Debug\PlayerStatsWinService.exe"