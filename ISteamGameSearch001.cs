
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamGameSearch001
    {
        public IntPtr AddGameSearchParams;
        public IntPtr SearchForGameWithLobby;
        public IntPtr SearchForGameSolo;
        public IntPtr AcceptGame;
        public IntPtr DeclineGame;
        public IntPtr RetrieveConnectionDetails;
        public IntPtr EndGameSearch;
        public IntPtr SetGameHostParams;
        public IntPtr SetConnectionDetails;
        public IntPtr RequestPlayersForGame;
        public IntPtr HostConfirmGameStart;
        public IntPtr CancelRequestPlayersForGame;
        public IntPtr SubmitPlayerResult;
        public IntPtr EndGame;
    }
}
