
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamRemoteStorage013
    {
        public IntPtr FileWrite;
        public IntPtr FileRead;
        public IntPtr FileWriteAsync;
        public IntPtr FileReadAsync;
        public IntPtr FileReadAsyncComplete;
        public IntPtr FileForget;
        public IntPtr FileDelete;
        public IntPtr FileShare;
        public IntPtr SetSyncPlatforms;
        public IntPtr FileWriteStreamOpen;
        public IntPtr FileWriteStreamWriteChunk;
        public IntPtr FileWriteStreamClose;
        public IntPtr FileWriteStreamCancel;
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
        public IntPtr GetUGCDownloadProgress;
        public IntPtr GetUGCDetails;
        public IntPtr UGCRead;
        public IntPtr GetCachedUGCCount;
        public IntPtr GetCachedUGCHandle;
        public IntPtr PublishWorkshopFile;
        public IntPtr CreatePublishedFileUpdateRequest;
        public IntPtr UpdatePublishedFileFile;
        public IntPtr UpdatePublishedFilePreviewFile;
        public IntPtr UpdatePublishedFileTitle;
        public IntPtr UpdatePublishedFileDescription;
        public IntPtr UpdatePublishedFileVisibility;
        public IntPtr UpdatePublishedFileTags;
        public IntPtr CommitPublishedFileUpdate;
        public IntPtr GetPublishedFileDetails;
        public IntPtr DeletePublishedFile;
        public IntPtr EnumerateUserPublishedFiles;
        public IntPtr SubscribePublishedFile;
        public IntPtr EnumerateUserSubscribedFiles;
        public IntPtr UnsubscribePublishedFile;
        public IntPtr UpdatePublishedFileSetChangeDescription;
        public IntPtr GetPublishedItemVoteDetails;
        public IntPtr UpdateUserPublishedItemVote;
        public IntPtr GetUserPublishedItemVoteDetails;
        public IntPtr EnumerateUserSharedWorkshopFiles;
        public IntPtr PublishVideo;
        public IntPtr SetUserPublishedFileAction;
        public IntPtr EnumeratePublishedFilesByUserAction;
        public IntPtr EnumeratePublishedWorkshopFiles;
        public IntPtr UGCDownloadToLocation;
    }
}
