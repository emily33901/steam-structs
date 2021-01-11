
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientGameServerStats
    {
        public IntPtr RequestUserStats;
        public IntPtr GetUserStat;
        public IntPtr GetUserStat2;
        public IntPtr GetUserAchievement;
        public IntPtr SetUserStat;
        public IntPtr SetUserStat2;
        public IntPtr UpdateUserAvgRateStat;
        public IntPtr SetUserAchievement;
        public IntPtr ClearUserAchievement;
        public IntPtr StoreUserStats;
        public IntPtr SetMaxStatsLoaded;
    }
}
