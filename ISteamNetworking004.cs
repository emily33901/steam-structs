
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamNetworking004
    {
        public IntPtr SendP2PPacket;
        public IntPtr IsP2PPacketAvailable;
        public IntPtr ReadP2PPacket;
        public IntPtr AcceptP2PSessionWithUser;
        public IntPtr CloseP2PSessionWithUser;
        public IntPtr GetP2PSessionState;
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
        public IntPtr GetSocketConnectionType;
        public IntPtr GetMaxPacketSize;
    }
}
