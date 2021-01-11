
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamVideo002
    {
        public IntPtr GetVideoURL;
        public IntPtr IsBroadcasting;
        public IntPtr GetOPFSettings;
        public IntPtr GetOPFStringForApp;
    }
}
