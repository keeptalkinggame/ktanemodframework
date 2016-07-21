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
}
