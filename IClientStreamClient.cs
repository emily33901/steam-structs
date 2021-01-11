
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientStreamClient
    {
        public IntPtr Launched;
        public IntPtr FocusGained;
        public IntPtr FocusLost;
        public IntPtr Finished;
        public IntPtr BGetStreamingClientConfig;
        public IntPtr BSaveStreamingClientConfig;
        public IntPtr GetSystemInfo;
        public IntPtr StartStreamingSession;
        public IntPtr ReportStreamingSessionEvent;
        public IntPtr FinishStreamingSession;
    }
}
