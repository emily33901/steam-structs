
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamFriends008
    {
        public IntPtr GetPersonaName;
        public IntPtr SetPersonaName;
        public IntPtr GetPersonaState;
        public IntPtr GetFriendCount;
        public IntPtr GetFriendByIndex;
        public IntPtr GetFriendRelationship;
        public IntPtr GetFriendPersonaState;
        public IntPtr GetFriendPersonaName;
        public IntPtr GetFriendGamePlayed;
        public IntPtr GetFriendPersonaNameHistory;
        public IntPtr HasFriend;
        public IntPtr GetClanCount;
        public IntPtr GetClanByIndex;
        public IntPtr GetClanName;
        public IntPtr GetClanTag;
        public IntPtr GetFriendCountFromSource;
        public IntPtr GetFriendFromSourceByIndex;
        public IntPtr IsUserInSource;
        public IntPtr SetInGameVoiceSpeaking;
        public IntPtr ActivateGameOverlay;
        public IntPtr ActivateGameOverlayToUser;
        public IntPtr ActivateGameOverlayToWebPage;
        public IntPtr ActivateGameOverlayToStore;
        public IntPtr SetPlayedWith;
        public IntPtr ActivateGameOverlayInviteDialog;
        public IntPtr GetSmallFriendAvatar;
        public IntPtr GetMediumFriendAvatar;
        public IntPtr GetLargeFriendAvatar;
        public IntPtr RequestUserInformation;
        public IntPtr RequestClanOfficerList;
        public IntPtr GetClanOwner;
        public IntPtr GetClanOfficerCount;
        public IntPtr GetClanOfficerByIndex;
        public IntPtr GetUserRestrictions;
    }
}
