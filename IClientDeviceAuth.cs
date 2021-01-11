
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientDeviceAuth
    {
        public IntPtr AuthorizeLocalDevice;
        public IntPtr DeauthorizeDevice;
        public IntPtr RequestAuthorizationInfos;
        public IntPtr GetDeviceAuthorizations;
        public IntPtr GetDeviceAuthorizationInfo;
        public IntPtr GetAuthorizedBorrowers;
        public IntPtr GetLocalUsers;
        public IntPtr GetBorrowerInfo;
        public IntPtr UpdateAuthorizedBorrowers;
        public IntPtr GetSharedLibraryLockedBy;
        public IntPtr GetSharedLibraryOwners;
    }
}
