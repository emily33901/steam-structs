
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamUGC007
    {
        public IntPtr CreateQueryUserUGCRequest;
        public IntPtr CreateQueryAllUGCRequest;
        public IntPtr CreateQueryUGCDetailsRequest;
        public IntPtr SendQueryUGCRequest;
        public IntPtr GetQueryUGCResult;
        public IntPtr GetQueryUGCPreviewURL;
        public IntPtr GetQueryUGCMetadata;
        public IntPtr GetQueryUGCChildren;
        public IntPtr GetQueryUGCStatistic;
        public IntPtr GetQueryUGCNumAdditionalPreviews;
        public IntPtr GetQueryUGCAdditionalPreview;
        public IntPtr GetQueryUGCNumKeyValueTags;
        public IntPtr GetQueryUGCKeyValueTag;
        public IntPtr ReleaseQueryUGCRequest;
        public IntPtr AddRequiredTag;
        public IntPtr AddExcludedTag;
        public IntPtr SetReturnKeyValueTags;
        public IntPtr SetReturnLongDescription;
        public IntPtr SetReturnMetadata;
        public IntPtr SetReturnChildren;
        public IntPtr SetReturnAdditionalPreviews;
        public IntPtr SetReturnTotalOnly;
        public IntPtr SetLanguage;
        public IntPtr SetAllowCachedResponse;
        public IntPtr SetCloudFileNameFilter;
        public IntPtr SetMatchAnyTag;
        public IntPtr SetSearchText;
        public IntPtr SetRankedByTrendDays;
        public IntPtr AddRequiredKeyValueTag;
        public IntPtr RequestUGCDetails;
        public IntPtr CreateItem;
        public IntPtr StartItemUpdate;
        public IntPtr SetItemTitle;
        public IntPtr SetItemDescription;
        public IntPtr SetItemUpdateLanguage;
        public IntPtr SetItemMetadata;
        public IntPtr SetItemVisibility;
        public IntPtr SetItemTags;
        public IntPtr SetItemContent;
        public IntPtr SetItemPreview;
        public IntPtr RemoveItemKeyValueTags;
        public IntPtr AddItemKeyValueTag;
        public IntPtr SubmitItemUpdate;
        public IntPtr GetItemUpdateProgress;
        public IntPtr SetUserItemVote;
        public IntPtr GetUserItemVote;
        public IntPtr AddItemToFavorites;
        public IntPtr RemoveItemFromFavorites;
        public IntPtr SubscribeItem;
        public IntPtr UnsubscribeItem;
        public IntPtr GetNumSubscribedItems;
        public IntPtr GetSubscribedItems;
        public IntPtr GetItemState;
        public IntPtr GetItemInstallInfo;
        public IntPtr GetItemDownloadInfo;
        public IntPtr DownloadItem;
        public IntPtr BInitWorkshopForGameServer;
        public IntPtr SuspendDownloads;
    }
}
