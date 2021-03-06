class IClientShortcuts {
	virtual unknown_ret GetUniqueLocalAppId() = 0;
	virtual unknown_ret GetGameIDForAppID(unsigned int) = 0;
	virtual unknown_ret GetAppIDForGameID(CGameID) = 0;
	virtual unknown_ret GetShortcutCount() = 0;
	virtual unknown_ret GetShortcutAppIDByIndex(unsigned int) = 0;
	virtual unknown_ret GetShortcutAppNameByIndex(unsigned int) = 0;
	virtual unknown_ret GetShortcutExeByIndex(unsigned int) = 0;
	virtual unknown_ret GetShortcutUserTagCountByIndex(unsigned int) = 0;
	virtual unknown_ret GetShortcutUserTagByIndex(unsigned int, unsigned int) = 0;
	virtual unknown_ret BIsShortcutRemoteByIndex(unsigned int) = 0;
	virtual unknown_ret BIsTemporaryShortcutByIndex(unsigned int) = 0;
	virtual unknown_ret BIsOpenVRShortcutByIndex(unsigned int) = 0;
	virtual unknown_ret BIsDevkitShortcutByIndex(unsigned int) = 0;
	virtual unknown_ret GetDevkitGameIDByIndex(unsigned int) = 0;
	virtual unknown_ret GetDevkitAppIDByDevkitGameID(char const*) = 0;
	virtual unknown_ret GetShortcutAppNameByAppID(unsigned int) = 0;
	virtual unknown_ret GetShortcutExeByAppID(unsigned int) = 0;
	virtual unknown_ret GetShortcutStartDirByAppID(unsigned int) = 0;
	virtual unknown_ret GetShortcutIconByAppID(unsigned int) = 0;
	virtual unknown_ret GetShortcutPathByAppID(unsigned int) = 0;
	virtual unknown_ret GetShortcutCommandLine(unsigned int) = 0;
	virtual unknown_ret GetShortcutUserTagCountByAppID(unsigned int) = 0;
	virtual unknown_ret GetShortcutUserTagByAppID(unsigned int, unsigned int) = 0;
	virtual unknown_ret BIsShortcutRemoteByAppID(unsigned int) = 0;
	virtual unknown_ret BIsShortcutHiddenByAppID(unsigned int) = 0;
	virtual unknown_ret BIsTemporaryShortcutByAppID(unsigned int) = 0;
	virtual unknown_ret BIsOpenVRShortcutByAppID(unsigned int) = 0;
	virtual unknown_ret BAllowDesktopConfigByAppID(unsigned int) = 0;
	virtual unknown_ret BAllowOverlayByAppID(unsigned int) = 0;
	virtual unknown_ret GetShortcutLastPlayedTime(unsigned int) = 0;
	virtual unknown_ret AddShortcut(char const*, char const*, char const*, char const*, char const*) = 0;
	virtual unknown_ret AddTemporaryShortcut(char const*, char const*, char const*) = 0;
	virtual unknown_ret AddOpenVRShortcut(char const*, char const*, char const*) = 0;
	virtual unknown_ret SetShortcutFromFullpath(unsigned int, char const*) = 0;
	virtual unknown_ret SetShortcutAppName(unsigned int, char const*) = 0;
	virtual unknown_ret SetShortcutExe(unsigned int, char const*) = 0;
	virtual unknown_ret SetShortcutStartDir(unsigned int, char const*) = 0;
	virtual unknown_ret SetShortcutIcon(unsigned int, char const*) = 0;
	virtual unknown_ret SetShortcutCommandLine(unsigned int, char const*) = 0;
	virtual unknown_ret ClearShortcutUserTags(unsigned int) = 0;
	virtual unknown_ret AddShortcutUserTag(unsigned int, char const*) = 0;
	virtual unknown_ret RemoveShortcutUserTag(unsigned int, char const*) = 0;
	virtual unknown_ret ClearAndSetShortcutUserTags(unsigned int, SteamParamStringArray_t const*) = 0;
	virtual unknown_ret SetShortcutHidden(unsigned int, bool) = 0;
	virtual unknown_ret SetAllowDesktopConfig(unsigned int, bool) = 0;
	virtual unknown_ret SetAllowOverlay(unsigned int, bool) = 0;
	virtual unknown_ret SetOpenVRShortcut(unsigned int, bool) = 0;
	virtual unknown_ret SetDevkitShortcut(unsigned int, char const*) = 0;
	virtual unknown_ret RemoveShortcut(unsigned int) = 0;
	virtual unknown_ret RemoveAllTemporaryShortcuts() = 0;
	virtual unknown_ret LaunchShortcut(unsigned int, unsigned int) = 0;
};
