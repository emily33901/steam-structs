
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamMusicRemote001
    {
        public IntPtr RegisterSteamMusicRemote;
        public IntPtr DeregisterSteamMusicRemote;
        public IntPtr BIsCurrentMusicRemote;
        public IntPtr BActivationSuccess;
        public IntPtr SetDisplayName;
        public IntPtr SetPNGIcon_64x64;
        public IntPtr EnablePlayPrevious;
        public IntPtr EnablePlayNext;
        public IntPtr EnableShuffled;
        public IntPtr EnableLooped;
        public IntPtr EnableQueue;
        public IntPtr EnablePlaylists;
        public IntPtr UpdatePlaybackStatus;
        public IntPtr UpdateShuffled;
        public IntPtr UpdateLooped;
        public IntPtr UpdateVolume;
        public IntPtr CurrentEntryWillChange;
        public IntPtr CurrentEntryIsAvailable;
        public IntPtr UpdateCurrentEntryText;
        public IntPtr UpdateCurrentEntryElapsedSeconds;
        public IntPtr UpdateCurrentEntryCoverArt;
        public IntPtr CurrentEntryDidChange;
        public IntPtr QueueWillChange;
        public IntPtr ResetQueueEntries;
        public IntPtr SetQueueEntry;
        public IntPtr SetCurrentQueueEntry;
        public IntPtr QueueDidChange;
        public IntPtr PlaylistWillChange;
        public IntPtr ResetPlaylistEntries;
        public IntPtr SetPlaylistEntry;
        public IntPtr SetCurrentPlaylistEntry;
        public IntPtr PlaylistDidChange;
    }
}
