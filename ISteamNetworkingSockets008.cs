
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamNetworkingSockets008
    {
        public IntPtr CreateListenSocketIP;
        public IntPtr ConnectByIPAddress;
        public IntPtr CreateListenSocketP2P;
        public IntPtr ConnectP2P;
        public IntPtr AcceptConnection;
        public IntPtr CloseConnection;
        public IntPtr CloseListenSocket;
        public IntPtr SetConnectionUserData;
        public IntPtr GetConnectionUserData;
        public IntPtr SetConnectionName;
        public IntPtr GetConnectionName;
        public IntPtr SendMessageToConnection;
        public IntPtr SendMessages;
        public IntPtr FlushMessagesOnConnection;
        public IntPtr ReceiveMessagesOnConnection;
        public IntPtr GetConnectionInfo;
        public IntPtr GetQuickConnectionStatus;
        public IntPtr GetDetailedConnectionStatus;
        public IntPtr GetListenSocketAddress;
        public IntPtr CreateSocketPair;
        public IntPtr GetIdentity;
        public IntPtr InitAuthentication;
        public IntPtr GetAuthenticationStatus;
        public IntPtr CreatePollGroup;
        public IntPtr DestroyPollGroup;
        public IntPtr SetConnectionPollGroup;
        public IntPtr ReceiveMessagesOnPollGroup;
        public IntPtr ReceivedRelayAuthTicket;
        public IntPtr FindRelayAuthTicketForServer;
        public IntPtr ConnectToHostedDedicatedServer;
        public IntPtr GetHostedDedicatedServerPort;
        public IntPtr GetHostedDedicatedServerPOPID;
        public IntPtr GetHostedDedicatedServerAddress;
        public IntPtr CreateHostedDedicatedServerListenSocket;
        public IntPtr GetGameCoordinatorServerLogin;
        public IntPtr ConnectP2PCustomSignaling;
        public IntPtr ReceivedP2PCustomSignal;
        public IntPtr GetCertificateRequest;
        public IntPtr SetCertificate;
    }
}
