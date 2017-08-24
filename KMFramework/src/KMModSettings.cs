using UnityEngine;

/// <summary>
/// Interface to access the contents of the user settings stored in modSettings.json in the mod's directory.
/// Useful for user-specific settings in a mod, such as configuring a Twitch account or anything else a user
/// may tweak about a mod.
/// </summary>
public class KMModSettings : MonoBehaviour
{
    /// <summary>
    /// The contents of modSettings.json in this mod's directory, containing any user-specific data they may have put there.
    /// </summary>
    public string Settings;

    /// <summary>
    /// The location of the ModSettings file that can be used to refresh Settings without reloading the mod
    /// Set automatically by game overwriting anything that you put here
    /// </summary>
    public string SettingsPath;

    /// <summary>
    /// Refreshes settings from file, requires file access so good to use sparingly
    /// </summary>
    public void RefreshSettings()
    {
        if (OnRefreshSettings != null)
        {
            OnRefreshSettings();
        }
    }

    #region Delegates
    /// <summary>
    /// Delegate type for refreshing settings
    /// </summary>
    public delegate void KMOnRefreshSettingsDelegate();

    #endregion

    #region DO NOT USE IN MOD
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to refresh settings
    /// </summary>
    public KMOnRefreshSettingsDelegate OnRefreshSettings;

    #endregion
}
