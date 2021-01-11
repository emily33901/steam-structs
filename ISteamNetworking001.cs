
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamNetworking001
    {
        public IntPtr CreateListenSocket;
        public IntPtr CreateP2PConnectionSocket;
        public IntPtr CreateConnectionSocket;
        public IntPtr DestroySocket;
        public IntPtr DestroyListenSocket;
        public IntPtr SendDataOnSocket;
        public IntPtr IsDataAvailableOnSocket;
        public IntPtr RetrieveDataFromSocket;
        public IntPtr IsDataAvailable;
        public IntPtr RetrieveData;
        public IntPtr GetSocketInfo;
        public IntPtr GetListenSocketInfo;
    }
}
