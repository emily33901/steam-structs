
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientShortcuts
    {
        public IntPtr GetUniqueLocalAppId;
        public IntPtr GetGameIDForAppID;
        public IntPtr GetAppIDForGameID;
        public IntPtr GetShortcutCount;
        public IntPtr GetShortcutAppIDByIndex;
        public IntPtr GetShortcutAppNameByIndex;
        public IntPtr GetShortcutExeByIndex;
        public IntPtr GetShortcutUserTagCountByIndex;
        public IntPtr GetShortcutUserTagByIndex;
        public IntPtr BIsShortcutRemoteByIndex;
        public IntPtr BIsTemporaryShortcutByIndex;
        public IntPtr BIsOpenVRShortcutByIndex;
        public IntPtr BIsDevkitShortcutByIndex;
        public IntPtr GetDevkitGameIDByIndex;
        public IntPtr GetDevkitAppIDByDevkitGameID;
        public IntPtr GetShortcutAppNameByAppID;
        public IntPtr GetShortcutExeByAppID;
        public IntPtr GetShortcutStartDirByAppID;
        public IntPtr GetShortcutIconByAppID;
        public IntPtr GetShortcutPathByAppID;
        public IntPtr GetShortcutCommandLine;
        public IntPtr GetShortcutUserTagCountByAppID;
        public IntPtr GetShortcutUserTagByAppID;
        public IntPtr BIsShortcutRemoteByAppID;
        public IntPtr BIsShortcutHiddenByAppID;
        public IntPtr BIsTemporaryShortcutByAppID;
        public IntPtr BIsOpenVRShortcutByAppID;
        public IntPtr BAllowDesktopConfigByAppID;
        public IntPtr BAllowOverlayByAppID;
        public IntPtr GetShortcutLastPlayedTime;
        public IntPtr AddShortcut;
        public IntPtr AddTemporaryShortcut;
        public IntPtr AddOpenVRShortcut;
        public IntPtr SetShortcutFromFullpath;
        public IntPtr SetShortcutAppName;
        public IntPtr SetShortcutExe;
        public IntPtr SetShortcutStartDir;
        public IntPtr SetShortcutIcon;
        public IntPtr SetShortcutCommandLine;
        public IntPtr ClearShortcutUserTags;
        public IntPtr AddShortcutUserTag;
        public IntPtr RemoveShortcutUserTag;
        public IntPtr ClearAndSetShortcutUserTags;
        public IntPtr SetShortcutHidden;
        public IntPtr SetAllowDesktopConfig;
        public IntPtr SetAllowOverlay;
        public IntPtr SetOpenVRShortcut;
        public IntPtr SetDevkitShortcut;
        public IntPtr RemoveShortcut;
        public IntPtr RemoveAllTemporaryShortcuts;
        public IntPtr LaunchShortcut;
    }
}
