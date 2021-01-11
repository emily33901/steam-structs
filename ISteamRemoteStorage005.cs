
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamRemoteStorage005
    {
        public IntPtr FileWrite;
        public IntPtr FileRead;
        public IntPtr FileForget;
        public IntPtr FileDelete;
        public IntPtr FileShare;
        public IntPtr SetSyncPlatforms;
        public IntPtr FileExists;
        public IntPtr FilePersisted;
        public IntPtr GetFileSize;
        public IntPtr GetFileTimestamp;
        public IntPtr GetSyncPlatforms;
        public IntPtr GetFileCount;
        public IntPtr GetFileNameAndSize;
        public IntPtr GetQuota;
        public IntPtr IsCloudEnabledForAccount;
        public IntPtr IsCloudEnabledForApp;
        public IntPtr SetCloudEnabledForApp;
        public IntPtr UGCDownload;
        public IntPtr GetUGCDetails;
        public IntPtr UGCRead;
        public IntPtr GetCachedUGCCount;
        public IntPtr GetCachedUGCHandle;
        public IntPtr PublishFile;
        public IntPtr PublishWorkshopFile;
        public IntPtr UpdatePublishedFile;
        public IntPtr GetPublishedFileDetails;
        public IntPtr DeletePublishedFile;
        public IntPtr EnumerateUserPublishedFiles;
        public IntPtr SubscribePublishedFile;
        public IntPtr EnumerateUserSubscribedFiles;
        public IntPtr UnsubscribePublishedFile;
    }
}
