using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Add this component to a prefab to allow it to be used as a room during gameplay (i.e. bomb defusal).
/// </summary>
public class KMGameplayRoom : KMRoom
{
    public delegate void KMGameplayLightChange(bool on);

    public KMGameplayLightChange OnLightChange;

    /// <summary>
    /// Transform to spawn the alarm clock at when not in VR mod. Best to ensure this is in view of the camera at all times.
    /// </summary>
    public Transform AlarmClockSpawnNonVR;

    /// <summary>
    /// Transform to spawn the alarm clock at when in VR.
    /// </summary>
    public Transform AlarmClockSpawn;

    /// <summary>
    /// Use this if you want to specify a particular bomb to use in this room.
    /// </summary>
    public GameObject BombPrefabOverride;
}
