class ISteamRemoteStorage008 {
	virtual unknown_ret FileWrite(char const*, void const*, int) = 0;
	virtual unknown_ret FileRead(char const*, void*, int) = 0;
	virtual unknown_ret FileForget(char const*) = 0;
	virtual unknown_ret FileDelete(char const*) = 0;
	virtual unknown_ret FileShare(char const*) = 0;
	virtual unknown_ret SetSyncPlatforms(char const*, ERemoteStoragePlatform) = 0;
	virtual unknown_ret FileWriteStreamOpen(char const*) = 0;
	virtual unknown_ret FileWriteStreamWriteChunk(unsigned long long, void const*, int) = 0;
	virtual unknown_ret FileWriteStreamClose(unsigned long long) = 0;
	virtual unknown_ret FileWriteStreamCancel(unsigned long long) = 0;
	virtual unknown_ret FileExists(char const*) = 0;
	virtual unknown_ret FilePersisted(char const*) = 0;
	virtual unknown_ret GetFileSize(char const*) = 0;
	virtual unknown_ret GetFileTimestamp(char const*) = 0;
	virtual unknown_ret GetSyncPlatforms(char const*) = 0;
	virtual unknown_ret GetFileCount() = 0;
	virtual unknown_ret GetFileNameAndSize(int, int*) = 0;
	virtual unknown_ret GetQuota(int*, int*) = 0;
	virtual unknown_ret IsCloudEnabledForAccount() = 0;
	virtual unknown_ret IsCloudEnabledForApp() = 0;
	virtual unknown_ret SetCloudEnabledForApp(bool) = 0;
	virtual unknown_ret UGCDownload(unsigned long long) = 0;
	virtual unknown_ret GetUGCDownloadProgress(unsigned long long, int*, int*) = 0;
	virtual unknown_ret GetUGCDetails(unsigned long long, unsigned int*, char**, int*, CSteamID*) = 0;
	virtual unknown_ret UGCRead(unsigned long long, void*, int) = 0;
	virtual unknown_ret GetCachedUGCCount() = 0;
	virtual unknown_ret GetCachedUGCHandle(int) = 0;
	virtual unknown_ret PublishWorkshopFile(char const*, char const*, unsigned int, char const*, char const*, ERemoteStoragePublishedFileVisibility, SteamParamStringArray_t*, EWorkshopFileType) = 0;
	virtual unknown_ret CreatePublishedFileUpdateRequest(unsigned long long) = 0;
	virtual unknown_ret UpdatePublishedFileFile(unsigned long long, char const*) = 0;
	virtual unknown_ret UpdatePublishedFilePreviewFile(unsigned long long, char const*) = 0;
	virtual unknown_ret UpdatePublishedFileTitle(unsigned long long, char const*) = 0;
	virtual unknown_ret UpdatePublishedFileDescription(unsigned long long, char const*) = 0;
	virtual unknown_ret UpdatePublishedFileVisibility(unsigned long long, ERemoteStoragePublishedFileVisibility) = 0;
	virtual unknown_ret UpdatePublishedFileTags(unsigned long long, SteamParamStringArray_t*) = 0;
	virtual unknown_ret CommitPublishedFileUpdate(unsigned long long) = 0;
	virtual unknown_ret GetPublishedFileDetails(unsigned long long) = 0;
	virtual unknown_ret DeletePublishedFile(unsigned long long) = 0;
	virtual unknown_ret EnumerateUserPublishedFiles(unsigned int) = 0;
	virtual unknown_ret SubscribePublishedFile(unsigned long long) = 0;
	virtual unknown_ret EnumerateUserSubscribedFiles(unsigned int) = 0;
	virtual unknown_ret UnsubscribePublishedFile(unsigned long long) = 0;
	virtual unknown_ret UpdatePublishedFileSetChangeDescription(unsigned long long, char const*) = 0;
	virtual unknown_ret GetPublishedItemVoteDetails(unsigned long long) = 0;
	virtual unknown_ret UpdateUserPublishedItemVote(unsigned long long, bool) = 0;
	virtual unknown_ret GetUserPublishedItemVoteDetails(unsigned long long) = 0;
	virtual unknown_ret EnumerateUserSharedWorkshopFiles(CSteamID, unsigned int, SteamParamStringArray_t*, SteamParamStringArray_t*) = 0;
	virtual unknown_ret PublishVideo(EWorkshopVideoProvider, char const*, char const*, char const*, unsigned int, char const*, char const*, ERemoteStoragePublishedFileVisibility, SteamParamStringArray_t*) = 0;
	virtual unknown_ret SetUserPublishedFileAction(unsigned long long, EWorkshopFileAction) = 0;
	virtual unknown_ret EnumeratePublishedFilesByUserAction(EWorkshopFileAction, unsigned int) = 0;
	virtual unknown_ret EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType, unsigned int, unsigned int, unsigned int, SteamParamStringArray_t*, SteamParamStringArray_t*) = 0;
};