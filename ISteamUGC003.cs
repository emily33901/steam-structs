
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamUGC003
    {
        public IntPtr CreateQueryUserUGCRequest;
        public IntPtr CreateQueryAllUGCRequest;
        public IntPtr SendQueryUGCRequest;
        public IntPtr GetQueryUGCResult;
        public IntPtr ReleaseQueryUGCRequest;
        public IntPtr AddRequiredTag;
        public IntPtr AddExcludedTag;
        public IntPtr SetReturnLongDescription;
        public IntPtr SetReturnTotalOnly;
        public IntPtr SetAllowCachedResponse;
        public IntPtr SetCloudFileNameFilter;
        public IntPtr SetMatchAnyTag;
        public IntPtr SetSearchText;
        public IntPtr SetRankedByTrendDays;
        public IntPtr RequestUGCDetails;
        public IntPtr CreateItem;
        public IntPtr StartItemUpdate;
        public IntPtr SetItemTitle;
        public IntPtr SetItemDescription;
        public IntPtr SetItemVisibility;
        public IntPtr SetItemTags;
        public IntPtr SetItemContent;
        public IntPtr SetItemPreview;
        public IntPtr SubmitItemUpdate;
        public IntPtr GetItemUpdateProgress;
        public IntPtr SubscribeItem;
        public IntPtr UnsubscribeItem;
        public IntPtr GetNumSubscribedItems;
        public IntPtr GetSubscribedItems;
        public IntPtr GetItemInstallInfo;
        public IntPtr GetItemUpdateInfo;
    }
}
