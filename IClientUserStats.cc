class IClientUserStats {
	virtual unknown_ret GetNumStats(CGameID) = 0;
	virtual unknown_ret GetStatName(CGameID, unsigned int) = 0;
	virtual unknown_ret GetStatType(CGameID, char const*) = 0;
	virtual unknown_ret GetNumAchievements(CGameID) = 0;
	virtual unknown_ret GetAchievementName(CGameID, unsigned int) = 0;
	virtual unknown_ret RequestCurrentStats(CGameID) = 0;
	virtual unknown_ret GetStat(CGameID, char const*, int*) = 0;
	virtual unknown_ret GetStat(CGameID, char const*, float*) = 0;
	virtual unknown_ret SetStat(CGameID, char const*, int) = 0;
	virtual unknown_ret SetStat(CGameID, char const*, float) = 0;
	virtual unknown_ret UpdateAvgRateStat(CGameID, char const*, float, double) = 0;
	virtual unknown_ret GetAchievement(CGameID, char const*, bool*, unsigned int*) = 0;
	virtual unknown_ret SetAchievement(CGameID, char const*) = 0;
	virtual unknown_ret ClearAchievement(CGameID, char const*) = 0;
	virtual unknown_ret StoreStats(CGameID) = 0;
	virtual unknown_ret GetAchievementIcon(CGameID, char const*, EGetAchievementIcon) = 0;
	virtual unknown_ret BGetAchievementIconURL(CGameID, char const*, EGetAchievementIcon, char*, unsigned int) = 0;
	virtual unknown_ret GetAchievementDisplayAttribute(CGameID, char const*, char const*, bool) = 0;
	virtual unknown_ret IndicateAchievementProgress(CGameID, char const*, unsigned int, unsigned int) = 0;
	virtual unknown_ret SetMaxStatsLoaded(unsigned int) = 0;
	virtual unknown_ret RequestUserStats(CSteamID, CGameID) = 0;
	virtual unknown_ret GetUserStat(CSteamID, CGameID, char const*, int*) = 0;
	virtual unknown_ret GetUserStat(CSteamID, CGameID, char const*, float*) = 0;
	virtual unknown_ret GetUserAchievement(CSteamID, CGameID, char const*, bool*, unsigned int*) = 0;
	virtual unknown_ret ResetAllStats(CGameID, bool) = 0;
	virtual unknown_ret FindOrCreateLeaderboard(char const*, ELeaderboardSortMethod, ELeaderboardDisplayType) = 0;
	virtual unknown_ret FindLeaderboard(char const*) = 0;
	virtual unknown_ret GetLeaderboardName(unsigned long long) = 0;
	virtual unknown_ret GetLeaderboardEntryCount(unsigned long long) = 0;
	virtual unknown_ret GetLeaderboardSortMethod(unsigned long long) = 0;
	virtual unknown_ret GetLeaderboardDisplayType(unsigned long long) = 0;
	virtual unknown_ret DownloadLeaderboardEntries(unsigned long long, ELeaderboardDataRequest, int, int) = 0;
	virtual unknown_ret DownloadLeaderboardEntriesForUsers(unsigned long long, CSteamID*, int) = 0;
	virtual unknown_ret GetDownloadedLeaderboardEntry(unsigned long long, int, LeaderboardEntry_t*, int*, int) = 0;
	virtual unknown_ret AttachLeaderboardUGC(unsigned long long, unsigned long long) = 0;
	virtual unknown_ret UploadLeaderboardScore(unsigned long long, ELeaderboardUploadScoreMethod, int, int const*, int) = 0;
	virtual unknown_ret GetNumberOfCurrentPlayers() = 0;
	virtual unknown_ret GetNumAchievedAchievements(CGameID) = 0;
	virtual unknown_ret GetLastAchievementUnlocked(CGameID) = 0;
	virtual unknown_ret GetMostRecentAchievementUnlocked(CGameID, unsigned int) = 0;
	virtual unknown_ret RequestGlobalAchievementPercentages(CGameID) = 0;
	virtual unknown_ret GetMostAchievedAchievementInfo(CGameID, char*, unsigned int, float*, bool*) = 0;
	virtual unknown_ret GetNextMostAchievedAchievementInfo(CGameID, int, char*, unsigned int, float*, bool*) = 0;
	virtual unknown_ret GetAchievementAchievedPercent(CGameID, char const*, float*) = 0;
	virtual unknown_ret RequestGlobalStats(CGameID, int) = 0;
	virtual unknown_ret GetGlobalStat(CGameID, char const*, long long*) = 0;
	virtual unknown_ret GetGlobalStat(CGameID, char const*, double*) = 0;
	virtual unknown_ret GetGlobalStatHistory(CGameID, char const*, long long*, unsigned int) = 0;
	virtual unknown_ret GetGlobalStatHistory(CGameID, char const*, double*, unsigned int) = 0;
	virtual unknown_ret GetAchievementProgressLimits(CGameID, char const*, int*, int*) = 0;
	virtual unknown_ret GetAchievementProgressLimits(CGameID, char const*, float*, float*) = 0;
};