
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamUGC001
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
        public IntPtr SetCloudFileNameFilter;
        public IntPtr SetMatchAnyTag;
        public IntPtr SetSearchText;
        public IntPtr SetRankedByTrendDays;
        public IntPtr RequestUGCDetails;
    }
}
