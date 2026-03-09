using System;

namespace Miningcore.Stratum
{
    public class WorkerConnectionInfo
    {
        public string PoolId { get; init; } = default!;
        public string ConnectionId { get; init; } = default!;
        public string Miner { get; set; } = default!;
        public string Worker { get; set; } = default!;
        public int Port { get; init; }

        /// <summary>
        /// Last activity (f.e. last Share or Ping).
        /// </summary>
        public DateTime LastActivity { get; set; } = DateTime.UtcNow;
    }

    public class PortStats
    {
        public int Port { get; init; }
        public int ActiveWorkers { get; init; }
        public int UniqueMiners { get; init; }
    }
}
