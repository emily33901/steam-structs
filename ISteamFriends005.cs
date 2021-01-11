
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamFriends005
    {
        public IntPtr GetPersonaName;
        public IntPtr SetPersonaName;
        public IntPtr GetPersonaState;
        public IntPtr GetFriendCount;
        public IntPtr GetFriendByIndex;
        public IntPtr GetFriendRelationship;
        public IntPtr GetFriendPersonaState;
        public IntPtr GetFriendPersonaName;
        public IntPtr GetFriendAvatar;
        public IntPtr GetFriendGamePlayed;
        public IntPtr GetFriendPersonaNameHistory;
        public IntPtr HasFriend;
        public IntPtr GetClanCount;
        public IntPtr GetClanByIndex;
        public IntPtr GetClanName;
        public IntPtr GetFriendCountFromSource;
        public IntPtr GetFriendFromSourceByIndex;
        public IntPtr IsUserInSource;
        public IntPtr SetInGameVoiceSpeaking;
        public IntPtr ActivateGameOverlay;
        public IntPtr ActivateGameOverlayToUser;
        public IntPtr ActivateGameOverlayToWebPage;
        public IntPtr ActivateGameOverlayToStore;
        public IntPtr SetPlayedWith;
    }
}
