
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamNetworkingMessages002
    {
        public IntPtr SendMessageToUser;
        public IntPtr ReceiveMessagesOnChannel;
        public IntPtr AcceptSessionWithUser;
        public IntPtr CloseSessionWithUser;
        public IntPtr CloseChannelWithUser;
        public IntPtr GetSessionConnectionInfo;
    }
}
