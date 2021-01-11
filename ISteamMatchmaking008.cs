
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamMatchmaking008
    {
        public IntPtr GetFavoriteGameCount;
        public IntPtr GetFavoriteGame;
        public IntPtr AddFavoriteGame;
        public IntPtr RemoveFavoriteGame;
        public IntPtr RequestLobbyList;
        public IntPtr AddRequestLobbyListStringFilter;
        public IntPtr AddRequestLobbyListNumericalFilter;
        public IntPtr AddRequestLobbyListNearValueFilter;
        public IntPtr AddRequestLobbyListFilterSlotsAvailable;
        public IntPtr AddRequestLobbyListDistanceFilter;
        public IntPtr AddRequestLobbyListResultCountFilter;
        public IntPtr GetLobbyByIndex;
        public IntPtr CreateLobby;
        public IntPtr JoinLobby;
        public IntPtr LeaveLobby;
        public IntPtr InviteUserToLobby;
        public IntPtr GetNumLobbyMembers;
        public IntPtr GetLobbyMemberByIndex;
        public IntPtr GetLobbyData;
        public IntPtr SetLobbyData;
        public IntPtr GetLobbyDataCount;
        public IntPtr GetLobbyDataByIndex;
        public IntPtr DeleteLobbyData;
        public IntPtr GetLobbyMemberData;
        public IntPtr SetLobbyMemberData;
        public IntPtr SendLobbyChatMsg;
        public IntPtr GetLobbyChatEntry;
        public IntPtr RequestLobbyData;
        public IntPtr SetLobbyGameServer;
        public IntPtr GetLobbyGameServer;
        public IntPtr SetLobbyMemberLimit;
        public IntPtr GetLobbyMemberLimit;
        public IntPtr SetLobbyType;
        public IntPtr SetLobbyJoinable;
        public IntPtr GetLobbyOwner;
        public IntPtr SetLobbyOwner;
    }
}
