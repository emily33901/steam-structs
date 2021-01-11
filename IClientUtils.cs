
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientUtils
    {
        public IntPtr GetInstallPath;
        public IntPtr GetUserBaseFolderInstallImage;
        public IntPtr GetManagedContentRoot;
        public IntPtr GetSecondsSinceAppActive;
        public IntPtr GetSecondsSinceComputerActive;
        public IntPtr SetComputerActive;
        public IntPtr GetConnectedUniverse;
        public IntPtr GetServerRealTime;
        public IntPtr GetIPCountry;
        public IntPtr GetImageSize;
        public IntPtr GetImageRGBA;
        public IntPtr GetNumRunningApps;
        public IntPtr GetCurrentBatteryPower;
        public IntPtr GetBatteryInformation;
        public IntPtr SetOfflineMode;
        public IntPtr GetOfflineMode;
        public IntPtr SetAppIDForCurrentPipe;
        public IntPtr GetAppID;
        public IntPtr SetAPIDebuggingActive;
        public IntPtr AllocPendingAPICallHandle;
        public IntPtr IsAPICallCompleted;
        public IntPtr GetAPICallFailureReason;
        public IntPtr GetAPICallResult;
        public IntPtr SetAPICallResultWithoutPostingCallback;
        public IntPtr SignalAppsToShutDown;
        public IntPtr SignalServiceAppsToDisconnect;
        public IntPtr TerminateAllAppsMultiStep;
        public IntPtr GetCellID;
        public IntPtr BIsGlobalInstance;
        public IntPtr CheckFileSignature;
        public IntPtr GetBuildID;
        public IntPtr SetCurrentUIMode;
        public IntPtr GetCurrentUIMode;
        public IntPtr ShutdownLauncher;
        public IntPtr SetLauncherType;
        public IntPtr GetLauncherType;
        public IntPtr ShowGamepadTextInput;
        public IntPtr GetEnteredGamepadTextLength;
        public IntPtr GetEnteredGamepadTextInput;
        public IntPtr GamepadTextInputClosed;
        public IntPtr SetSpew;
        public IntPtr BDownloadsDisabled;
        public IntPtr SetFocusedWindow;
        public IntPtr GetSteamUILanguage;
        public IntPtr CheckSteamReachable;
        public IntPtr SetLastGameLaunchMethod;
        public IntPtr SetVideoAdapterInfo;
        public IntPtr SetControllerOverrideMode;
        public IntPtr SetOverlayWindowFocusForPipe;
        public IntPtr GetGameOverlayUIInstanceFocusGameID;
        public IntPtr SetControllerConfigFileForAppID;
        public IntPtr GetControllerConfigFileForAppID;
        public IntPtr IsSteamRunningInVR;
        public IntPtr BIsRunningOnAlienwareAlpha;
        public IntPtr StartVRDashboard;
        public IntPtr IsVRHeadsetStreamingEnabled;
        public IntPtr SetVRHeadsetStreamingEnabled;
        public IntPtr GenerateSupportSystemReport;
        public IntPtr GetSupportSystemReport;
        public IntPtr GetAppIdForPid;
        public IntPtr SetClientUIProcess;
        public IntPtr BIsClientUIInForeground;
        public IntPtr SetOverlayChatBrowserInfo;
        public IntPtr ClearOverlayChatBrowserInfo;
        public IntPtr GetOverlayChatBrowserInfo;
        public IntPtr DispatchClientUINotification;
        public IntPtr RespondToClientUINotification;
        public IntPtr DispatchClientUICommand;
        public IntPtr DispatchComputerActiveStateChange;
        public IntPtr DispatchOpenURLInClient;
        public IntPtr UpdateWideVineCDM;
        public IntPtr DispatchClearAllBrowsingData;
        public IntPtr DispatchClientSettingsChanged;
        public IntPtr DispatchClientPostMessage;
        public IntPtr IsSteamChina;
        public IntPtr NeedsSteamChinaWorkshop;
        public IntPtr InitFilterText;
        public IntPtr FilterText;
        public IntPtr GetIPv6ConnectivityState;
        public IntPtr RecordSteamInterfaceCreation;
        public IntPtr StartRuntimeInformationGathering;
        public IntPtr GetRuntimeInformation;
        public IntPtr GetCloudGamingPlatform;
        public IntPtr BGetMacAddresses;
        public IntPtr BGetDiskSerialNumber;
        public IntPtr GetSteamEnvironmentForApp;
        public IntPtr TestHTTP;
        public IntPtr DumpJobs;
    }
}
