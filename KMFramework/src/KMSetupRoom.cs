using UnityEngine;

/// <summary>
/// Add this component to a prefab to allow it to be used as a room during setup (e.g. the office with the bomb binder and freeplay device).
/// </summary>
public class KMSetupRoom : KMRoom
{
    /// <summary>
    /// Transform at which the Freeplay Device should be spawned.
    /// </summary>
    public Transform FreeplayDeviceSpawn;

    /// <summary>
    /// Transform at which the Bomb Binder should be spawned.
    /// </summary>
    public Transform BombBinderSpawn;
}