
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientVideo
    {
        public IntPtr BGetUserVideoFolder;
        public IntPtr UnlockH264;
        public IntPtr EGetBroadcastReady;
        public IntPtr BeginBroadcastSession;
        public IntPtr EndBroadcastSession;
        public IntPtr IsBroadcasting;
        public IntPtr BIsUploadingThumbnails;
        public IntPtr GetBroadcastSessionID;
        public IntPtr ReceiveBroadcastChat;
        public IntPtr PostBroadcastChat;
        public IntPtr MuteBroadcastChatUser;
        public IntPtr InitBroadcastVideo;
        public IntPtr InitBroadcastAudio;
        public IntPtr UploadBroadcastFrame;
        public IntPtr UploadBroadcastThumbnail;
        public IntPtr DroppedVideoFrames;
        public IntPtr SetCurrentVideoEncodingRate;
        public IntPtr SetMicrophoneState;
        public IntPtr SetVideoSource;
        public IntPtr BroadcastRecorderError;
        public IntPtr LoadBroadcastSettings;
        public IntPtr SetBroadcastPermissions;
        public IntPtr GetBroadcastPermissions;
        public IntPtr GetBroadcastMaxKbps;
        public IntPtr GetBroadcastDelaySeconds;
        public IntPtr BGetBroadcastDimensions;
        public IntPtr GetBroadcastIncludeDesktop;
        public IntPtr GetBroadcastRecordSystemAudio;
        public IntPtr GetBroadcastRecordMic;
        public IntPtr GetBroadcastShowChatCorner;
        public IntPtr GetBroadcastShowDebugInfo;
        public IntPtr GetBroadcastShowReminderBanner;
        public IntPtr GetBroadcastEncoderSetting;
        public IntPtr InviteToBroadcast;
        public IntPtr IgnoreApprovalRequest;
        public IntPtr BroadcastFirstTimeComplete;
        public IntPtr SetInHomeStreamState;
        public IntPtr WatchBroadcast;
        public IntPtr GetWatchBroadcastMPD;
        public IntPtr GetApprovalRequestCount;
        public IntPtr GetApprovalRequests;
        public IntPtr AddBroadcastGameData;
        public IntPtr RemoveBroadcastGameData;
        public IntPtr AddTimelineMarker;
        public IntPtr RemoveTimelineMarker;
        public IntPtr AddRegion;
        public IntPtr RemoveRegion;
        public IntPtr GetVideoURL;
        public IntPtr GetOPFSettings;
        public IntPtr GetOPFStringForApp;
        public IntPtr WebRTCGetTURNAddress;
        public IntPtr WebRTCStartResult;
        public IntPtr WebRTCAddCandidate;
        public IntPtr WebRTCGetAnswer;
    }
}
