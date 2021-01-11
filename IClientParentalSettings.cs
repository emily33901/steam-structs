
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientParentalSettings
    {
        public IntPtr BIsParentalLockEnabled;
        public IntPtr BIsParentalLockLocked;
        public IntPtr BIsAppBlocked;
        public IntPtr BIsAppInBlockList;
        public IntPtr BIsFeatureBlocked;
        public IntPtr BIsFeatureInBlockList;
        public IntPtr BGetSerializedParentalSettings;
        public IntPtr BGetRecoveryEmail;
        public IntPtr BIsLockFromSiteLicense;
    }
}
