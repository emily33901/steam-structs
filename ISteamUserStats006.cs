
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamUserStats006
    {
        public IntPtr RequestCurrentStats;
        public IntPtr GetStat;
        public IntPtr GetStat2;
        public IntPtr SetStat;
        public IntPtr SetStat2;
        public IntPtr UpdateAvgRateStat;
        public IntPtr GetAchievement;
        public IntPtr SetAchievement;
        public IntPtr ClearAchievement;
        public IntPtr StoreStats;
        public IntPtr GetAchievementIcon;
        public IntPtr GetAchievementDisplayAttribute;
        public IntPtr IndicateAchievementProgress;
        public IntPtr RequestUserStats;
        public IntPtr GetUserStat;
        public IntPtr GetUserStat2;
        public IntPtr GetUserAchievement;
        public IntPtr ResetAllStats;
        public IntPtr FindOrCreateLeaderboard;
        public IntPtr FindLeaderboard;
        public IntPtr GetLeaderboardName;
        public IntPtr GetLeaderboardEntryCount;
        public IntPtr GetLeaderboardSortMethod;
        public IntPtr GetLeaderboardDisplayType;
        public IntPtr DownloadLeaderboardEntries;
        public IntPtr GetDownloadedLeaderboardEntry;
        public IntPtr UploadLeaderboardScore;
        public IntPtr GetNumberOfCurrentPlayers;
    }
}
