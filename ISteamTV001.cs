
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamTV001
    {
        public IntPtr IsBroadcasting;
        public IntPtr AddBroadcastGameData;
        public IntPtr RemoveBroadcastGameData;
        public IntPtr AddTimelineMarker;
        public IntPtr RemoveTimelineMarker;
        public IntPtr AddRegion;
        public IntPtr RemoveRegion;
    }
}
