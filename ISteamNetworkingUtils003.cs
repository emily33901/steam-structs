
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamNetworkingUtils003
    {
        public IntPtr AllocateMessage;
        public IntPtr GetRelayNetworkStatus;
        public IntPtr GetLocalPingLocation;
        public IntPtr EstimatePingTimeBetweenTwoLocations;
        public IntPtr EstimatePingTimeFromLocalHost;
        public IntPtr ConvertPingLocationToString;
        public IntPtr ParsePingLocationString;
        public IntPtr CheckPingDataUpToDate;
        public IntPtr GetPingToDataCenter;
        public IntPtr GetDirectPingToPOP;
        public IntPtr GetPOPCount;
        public IntPtr GetPOPList;
        public IntPtr GetLocalTimestamp;
        public IntPtr SetDebugOutputFunction;
        public IntPtr SetConfigValue;
        public IntPtr GetConfigValue;
        public IntPtr GetConfigValueInfo;
        public IntPtr GetFirstConfigValue;
        public IntPtr SteamNetworkingIPAddr_ToString;
        public IntPtr SteamNetworkingIPAddr_ParseString;
        public IntPtr SteamNetworkingIdentity_ToString;
        public IntPtr SteamNetworkingIdentity_ParseString;
    }
}
