class ISteamUGC012 {
	virtual unknown_ret CreateQueryUserUGCRequest(unsigned int, EUserUGCList, EUGCMatchingUGCType, EUserUGCListSortOrder, unsigned int, unsigned int, unsigned int) = 0;
	virtual unknown_ret CreateQueryAllUGCRequest(EUGCQuery, EUGCMatchingUGCType, unsigned int, unsigned int, unsigned int) = 0;
	virtual unknown_ret CreateQueryAllUGCRequest(EUGCQuery, EUGCMatchingUGCType, unsigned int, unsigned int, char const*) = 0;
	virtual unknown_ret CreateQueryUGCDetailsRequest(unsigned long long*, unsigned int) = 0;
	virtual unknown_ret SendQueryUGCRequest(unsigned long long) = 0;
	virtual unknown_ret GetQueryUGCResult(unsigned long long, unsigned int, SteamUGCDetails_t*) = 0;
	virtual unknown_ret GetQueryUGCPreviewURL(unsigned long long, unsigned int, char*, unsigned int) = 0;
	virtual unknown_ret GetQueryUGCMetadata(unsigned long long, unsigned int, char*, unsigned int) = 0;
	virtual unknown_ret GetQueryUGCChildren(unsigned long long, unsigned int, unsigned long long*, unsigned int) = 0;
	virtual unknown_ret GetQueryUGCStatistic(unsigned long long, unsigned int, EItemStatistic, unsigned long long*) = 0;
	virtual unknown_ret GetQueryUGCNumAdditionalPreviews(unsigned long long, unsigned int) = 0;
	virtual unknown_ret GetQueryUGCAdditionalPreview(unsigned long long, unsigned int, unsigned int, char*, unsigned int, char*, unsigned int, EItemPreviewType*) = 0;
	virtual unknown_ret GetQueryUGCNumKeyValueTags(unsigned long long, unsigned int) = 0;
	virtual unknown_ret GetQueryUGCKeyValueTag(unsigned long long, unsigned int, unsigned int, char*, unsigned int, char*, unsigned int) = 0;
	virtual unknown_ret ReleaseQueryUGCRequest(unsigned long long) = 0;
	virtual unknown_ret AddRequiredTag(unsigned long long, char const*) = 0;
	virtual unknown_ret AddExcludedTag(unsigned long long, char const*) = 0;
	virtual unknown_ret SetReturnOnlyIDs(unsigned long long, bool) = 0;
	virtual unknown_ret SetReturnKeyValueTags(unsigned long long, bool) = 0;
	virtual unknown_ret SetReturnLongDescription(unsigned long long, bool) = 0;
	virtual unknown_ret SetReturnMetadata(unsigned long long, bool) = 0;
	virtual unknown_ret SetReturnChildren(unsigned long long, bool) = 0;
	virtual unknown_ret SetReturnAdditionalPreviews(unsigned long long, bool) = 0;
	virtual unknown_ret SetReturnTotalOnly(unsigned long long, bool) = 0;
	virtual unknown_ret SetReturnPlaytimeStats(unsigned long long, unsigned int) = 0;
	virtual unknown_ret SetLanguage(unsigned long long, char const*) = 0;
	virtual unknown_ret SetAllowCachedResponse(unsigned long long, unsigned int) = 0;
	virtual unknown_ret SetCloudFileNameFilter(unsigned long long, char const*) = 0;
	virtual unknown_ret SetMatchAnyTag(unsigned long long, bool) = 0;
	virtual unknown_ret SetSearchText(unsigned long long, char const*) = 0;
	virtual unknown_ret SetRankedByTrendDays(unsigned long long, unsigned int) = 0;
	virtual unknown_ret AddRequiredKeyValueTag(unsigned long long, char const*, char const*) = 0;
	virtual unknown_ret RequestUGCDetails(unsigned long long, unsigned int) = 0;
	virtual unknown_ret CreateItem(unsigned int, EWorkshopFileType) = 0;
	virtual unknown_ret StartItemUpdate(unsigned int, unsigned long long) = 0;
	virtual unknown_ret SetItemTitle(unsigned long long, char const*) = 0;
	virtual unknown_ret SetItemDescription(unsigned long long, char const*) = 0;
	virtual unknown_ret SetItemUpdateLanguage(unsigned long long, char const*) = 0;
	virtual unknown_ret SetItemMetadata(unsigned long long, char const*) = 0;
	virtual unknown_ret SetItemVisibility(unsigned long long, ERemoteStoragePublishedFileVisibility) = 0;
	virtual unknown_ret SetItemTags(unsigned long long, SteamParamStringArray_t const*) = 0;
	virtual unknown_ret SetItemContent(unsigned long long, char const*) = 0;
	virtual unknown_ret SetItemPreview(unsigned long long, char const*) = 0;
	virtual unknown_ret SetAllowLegacyUpload(unsigned long long, bool) = 0;
	virtual unknown_ret RemoveItemKeyValueTags(unsigned long long, char const*) = 0;
	virtual unknown_ret AddItemKeyValueTag(unsigned long long, char const*, char const*) = 0;
	virtual unknown_ret AddItemPreviewFile(unsigned long long, char const*, EItemPreviewType) = 0;
	virtual unknown_ret AddItemPreviewVideo(unsigned long long, char const*) = 0;
	virtual unknown_ret UpdateItemPreviewFile(unsigned long long, unsigned int, char const*) = 0;
	virtual unknown_ret UpdateItemPreviewVideo(unsigned long long, unsigned int, char const*) = 0;
	virtual unknown_ret RemoveItemPreview(unsigned long long, unsigned int) = 0;
	virtual unknown_ret SubmitItemUpdate(unsigned long long, char const*) = 0;
	virtual unknown_ret GetItemUpdateProgress(unsigned long long, unsigned long long*, unsigned long long*) = 0;
	virtual unknown_ret SetUserItemVote(unsigned long long, bool) = 0;
	virtual unknown_ret GetUserItemVote(unsigned long long) = 0;
	virtual unknown_ret AddItemToFavorites(unsigned int, unsigned long long) = 0;
	virtual unknown_ret RemoveItemFromFavorites(unsigned int, unsigned long long) = 0;
	virtual unknown_ret SubscribeItem(unsigned long long) = 0;
	virtual unknown_ret UnsubscribeItem(unsigned long long) = 0;
	virtual unknown_ret GetNumSubscribedItems() = 0;
	virtual unknown_ret GetSubscribedItems(unsigned long long*, unsigned int) = 0;
	virtual unknown_ret GetItemState(unsigned long long) = 0;
	virtual unknown_ret GetItemInstallInfo(unsigned long long, unsigned long long*, char*, unsigned int, unsigned int*) = 0;
	virtual unknown_ret GetItemDownloadInfo(unsigned long long, unsigned long long*, unsigned long long*) = 0;
	virtual unknown_ret DownloadItem(unsigned long long, bool) = 0;
	virtual unknown_ret BInitWorkshopForGameServer(unsigned int, char const*) = 0;
	virtual unknown_ret SuspendDownloads(bool) = 0;
	virtual unknown_ret StartPlaytimeTracking(unsigned long long*, unsigned int) = 0;
	virtual unknown_ret StopPlaytimeTracking(unsigned long long*, unsigned int) = 0;
	virtual unknown_ret StopPlaytimeTrackingForAllItems() = 0;
	virtual unknown_ret AddDependency(unsigned long long, unsigned long long) = 0;
	virtual unknown_ret RemoveDependency(unsigned long long, unsigned long long) = 0;
	virtual unknown_ret AddAppDependency(unsigned long long, unsigned int) = 0;
	virtual unknown_ret RemoveAppDependency(unsigned long long, unsigned int) = 0;
	virtual unknown_ret GetAppDependencies(unsigned long long) = 0;
	virtual unknown_ret DeleteItem(unsigned long long) = 0;
};
