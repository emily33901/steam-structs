
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamMatchmaking002
    {
        public IntPtr GetFavoriteGameCount;
        public IntPtr GetFavoriteGame;
        public IntPtr AddFavoriteGame;
        public IntPtr RemoveFavoriteGame;
        public IntPtr RequestLobbyList;
        public IntPtr GetLobbyByIndex;
        public IntPtr CreateLobby;
        public IntPtr JoinLobby;
        public IntPtr LeaveLobby;
        public IntPtr InviteUserToLobby;
        public IntPtr GetNumLobbyMembers;
        public IntPtr GetLobbyMemberByIndex;
        public IntPtr GetLobbyData;
        public IntPtr SetLobbyData;
        public IntPtr GetLobbyMemberData;
        public IntPtr SetLobbyMemberData;
        public IntPtr SendLobbyChatMsg;
        public IntPtr GetLobbyChatEntry;
        public IntPtr RequestLobbyData;
        public IntPtr SetLobbyGameServer;
    }
}
