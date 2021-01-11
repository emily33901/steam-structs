
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientScreenshots
    {
        public IntPtr GetShortcutDisplayName;
        public IntPtr SetShortcutDisplayName;
        public IntPtr WriteScreenshot;
        public IntPtr AddScreenshotToLibrary;
        public IntPtr TriggerScreenshot;
        public IntPtr RequestScreenshotFromGame;
        public IntPtr SetLocation;
        public IntPtr TagUser;
        public IntPtr TagPublishedFile;
        public IntPtr ResolvePath;
        public IntPtr GetSizeOnDisk;
        public IntPtr GetSizeInCloud;
        public IntPtr IsPersisted;
        public IntPtr GetNumGamesWithLocalScreenshots;
        public IntPtr GetGameWithLocalScreenshots;
        public IntPtr GetLocalScreenshotCount;
        public IntPtr GetLocalScreenshot;
        public IntPtr GetLocalScreenshotByHandle;
        public IntPtr SetLocalScreenshotCaption;
        public IntPtr SetLocalScreenshotPrivacy;
        public IntPtr SetLocalScreenshotSpoiler;
        public IntPtr StartBatch;
        public IntPtr AddToBatch;
        public IntPtr UploadBatch;
        public IntPtr DeleteBatch;
        public IntPtr CancelBatch;
        public IntPtr RecoverOldScreenshots;
        public IntPtr GetTaggedUserCount;
        public IntPtr GetTaggedUser;
        public IntPtr GetLocation;
        public IntPtr GetTaggedPublishedFileCount;
        public IntPtr GetTaggedPublishedFile;
        public IntPtr GetScreenshotVRType;
        public IntPtr BGetUserScreenshotDirectory;
    }
}
