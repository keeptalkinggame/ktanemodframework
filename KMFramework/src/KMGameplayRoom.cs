using UnityEngine;

public class KMGameplayRoom : KMRoom
{
    public delegate void KMGameplayLightChange(bool on);

    public KMGameplayLightChange OnLightChange;

    public Transform AlarmClockSpawnNonVR;
    public Transform AlarmClockSpawn;

    /// <summary>
    /// Use this if you want to specify a particular bomb to use in this room.
    /// </summary>
    public GameObject BombPrefabOverride;
}
