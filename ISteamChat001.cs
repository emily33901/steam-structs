
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamChat001
    {
        public IntPtr RequestSteamGroupChatMessageNotifications;
        public IntPtr RequestSteamGroupChatMessageHistory;
        public IntPtr RequestSendSteamGroupChatMessage;
    }
}
