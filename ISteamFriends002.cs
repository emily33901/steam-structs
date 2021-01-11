
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamFriends002
    {
        public IntPtr GetPersonaName;
        public IntPtr SetPersonaName;
        public IntPtr GetPersonaState;
        public IntPtr SetPersonaState;
        public IntPtr GetFriendCount;
        public IntPtr GetFriendByIndex;
        public IntPtr GetFriendRelationship;
        public IntPtr GetFriendPersonaState;
        public IntPtr GetFriendPersonaName;
        public IntPtr SetFriendRegValue;
        public IntPtr GetFriendRegValue;
        public IntPtr GetFriendGamePlayed;
        public IntPtr GetFriendPersonaNameHistory;
        public IntPtr AddFriend;
        public IntPtr RemoveFriend;
        public IntPtr HasFriend;
        public IntPtr AddFriendByName;
        public IntPtr InviteFriendByEmail;
        public IntPtr GetChatMessage;
        public IntPtr SendMsgToFriend;
        public IntPtr GetChatIDOfChatHistoryStart;
        public IntPtr SetChatHistoryStart;
        public IntPtr ClearChatHistory;
        public IntPtr GetClanCount;
        public IntPtr GetClanByIndex;
        public IntPtr GetClanName;
        public IntPtr InviteFriendToClan;
        public IntPtr AcknowledgeInviteToClan;
        public IntPtr GetFriendCountFromSource;
        public IntPtr GetFriendFromSourceByIndex;
    }
}
