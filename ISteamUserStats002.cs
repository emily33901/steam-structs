
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamUserStats002
    {
        public IntPtr GetNumStats;
        public IntPtr GetStatName;
        public IntPtr GetStatType;
        public IntPtr GetNumAchievements;
        public IntPtr GetAchievementName;
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
    }
}
