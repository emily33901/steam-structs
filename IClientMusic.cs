
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientMusic
    {
        public IntPtr BIsEnabled;
        public IntPtr Enable;
        public IntPtr EnableCrawlLogging;
        public IntPtr BIsPlaying;
        public IntPtr GetQueueCount;
        public IntPtr GetCurrentQueueEntry;
        public IntPtr GetQueueEntryURI;
        public IntPtr GetQueueEntryData;
        public IntPtr GetQueueEntryOrigin;
        public IntPtr EmptyQueue;
        public IntPtr RemoveQueueEntry;
        public IntPtr AddArtistToQueue;
        public IntPtr AddTracksOfAlbumIDToQueue;
        public IntPtr AddAllTracksOfAlbumIDToQueue;
        public IntPtr AddTracksOfPlaylistIDToQueue;
        public IntPtr SetSuppressAutoTrackAdvance;
        public IntPtr GetPlaybackStatus;
        public IntPtr SetPlayingRepeatStatus;
        public IntPtr GetPlayingRepeatStatus;
        public IntPtr TogglePlayingRepeatStatus;
        public IntPtr SetPlayingShuffled;
        public IntPtr IsPlayingShuffled;
        public IntPtr Play;
        public IntPtr Pause;
        public IntPtr PlayPrevious;
        public IntPtr PlayNext;
        public IntPtr PlayEntry;
        public IntPtr TogglePlayPause;
        public IntPtr SetVolume;
        public IntPtr GetVolume;
        public IntPtr ToggleMuteVolume;
        public IntPtr IncreaseVolume;
        public IntPtr DecreaseVolume;
        public IntPtr SetPlaybackPosition;
        public IntPtr GetPlaybackPosition;
        public IntPtr GetPlaybackDuration;
        public IntPtr LocalLibraryCrawlTrack;
        public IntPtr ResetLocalLibrary;
        public IntPtr GetStatusLocalLibrary;
        public IntPtr SaveLocalLibraryDirectorySettings;
        public IntPtr GetLocalLibraryDirectoryEntryCount;
        public IntPtr GetLocalLibraryDirectoryEntry;
        public IntPtr AddLocalLibraryDirectoryEntry;
        public IntPtr ResetLocalLibraryDirectories;
        public IntPtr GetDefaultLocalLibraryDirectory;
        public IntPtr LocalLibraryStopCrawling;
        public IntPtr UpdateLocalLibraryDirectoriesToCrawl;
        public IntPtr BLocalLibraryIsCrawling;
        public IntPtr GetLocalLibraryTrackCount;
        public IntPtr GetLocalLibraryAlbumCount;
        public IntPtr GetLocalLibraryAlbumID;
        public IntPtr GetLocalLibraryAlbumIDEntry;
        public IntPtr GetLocalLibraryAlbumIDTrackEntry;
        public IntPtr GetLocalLibraryAlbumDirectoryForAlbumID;
        public IntPtr GetLocalLibraryAlbumSortNameForAlbumID;
        public IntPtr GetLocalLibraryArtistSortNameForAlbumID;
        public IntPtr GetLocalLibraryTrackCountForAlbumID;
        public IntPtr GetLocalLibraryAlbumIDTrackKey;
        public IntPtr GetLocalLibraryAlbumIDForTrackKey;
        public IntPtr GetLocalLibraryArtistCount;
        public IntPtr GetLocalLibraryArtistName;
        public IntPtr GetLocalLibraryAlbumCountForArtistName;
        public IntPtr GetLocalLibraryTrackAndAlbumCountOfArtistName;
        public IntPtr GetLocalLibraryAlbumIDForArtist;
        public IntPtr GetLocalLibraryRepresentativeAlbumIDForArtist;
        public IntPtr GetLocalLibraryTrackEntry;
        public IntPtr BRequestAllArtistListData;
        public IntPtr BRequestAllAlbumListData;
        public IntPtr BRequestAllTracksListDataForAlbumID;
        public IntPtr GetPlaylistCount;
        public IntPtr GetPlaylistID;
        public IntPtr GetPositionForPlaylistID;
        public IntPtr GetPlaylistIDForPosition;
        public IntPtr BRequestAllPlayListData;
        public IntPtr GetNextPlaylistName;
        public IntPtr InsertPlaylistWithNameAtPosition;
        public IntPtr MovePlaylistFromPositionToPosition;
        public IntPtr DeletePlaylistWithID;
        public IntPtr RenamePlaylistWithID;
        public IntPtr AddRandomTracksToPlaylistID;
        public IntPtr GetPlaylistIDData;
        public IntPtr GetPlaylistIDTrackCount;
        public IntPtr BRequestAllTracksListDataForPlaylistID;
        public IntPtr GetPlaylistIDTrackKey;
        public IntPtr GetPositionForPlaylistItemID;
        public IntPtr AddTrackKeyToPlaylistID;
        public IntPtr AddAlbumIDToPlaylistID;
        public IntPtr AddArtistNameToPlaylistID;
        public IntPtr AddPlaylistIDToPlaylistID;
        public IntPtr RemovePlaylistPositionFromPlaylistID;
        public IntPtr RemoveAllTracksFromPlaylistID;
        public IntPtr MoveTrackFromPositionToPositonInPlaylistID;
        public IntPtr AppendQueueToPlaylistID;
        public IntPtr GetLocalLibraryRepresentativeAlbumIDForPlaylist;
        public IntPtr MarkTrackKeyAsPlayed;
        public IntPtr GetMostRecentlyPlayedAlbums;
        public IntPtr GetMostRecentlyAddedAlbums;
        public IntPtr ActivateRemotePlayerWithID;
        public IntPtr GetActiveRemotePlayerID;
        public IntPtr GetRemotePlayerCount;
        public IntPtr GetRemotePlayerIDAndName;
        public IntPtr GetCurrentEntryTextForRemotePlayerWithID;
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
        public IntPtr RequestAlbumCoverForAlbumID;
        public IntPtr RequestAlbumCoverForTrackKey;
        public IntPtr GetAlbumCoverForIndex;
        public IntPtr CancelAlbumCoverRequestForIndex;
        public IntPtr GetAlbumCoverURLForAlbumID;
        public IntPtr GetAlbumCoverURLForTrackKey;
        public IntPtr StartUsingSpotify;
        public IntPtr StopUsingSpotify;
        public IntPtr GetStatusSpotify;
        public IntPtr LoginSpotify;
        public IntPtr ReloginSpotify;
        public IntPtr GetCurrentUserSpotify;
        public IntPtr ForgetCurrentUserSpotify;
        public IntPtr LogoutSpotify;
        public IntPtr DumpStatusToConsole;
        public IntPtr ReplacePlaylistWithSoundtrackAlbum;
    }
}
