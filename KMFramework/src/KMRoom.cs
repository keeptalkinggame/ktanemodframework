using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Generic room behaviour - use KMGameplayRoom or KMSetupRoom instead.
/// </summary>
[DisallowMultipleComponent]
public abstract class KMRoom : MonoBehaviour
{
    /// <summary>
    /// Transform to spawn the bomb at.
    /// </summary>
    public Transform BombSpawnPosition;

    /// <summary>
    /// Transform to spawn the player at.
    /// </summary>
    public Transform PlayerSpawnPosition;

    /// <summary>
    /// Transform to spawn the Menu dossier at.
    /// </summary>
    public Transform DossierSpawn;

    /// <summary>
    /// The Animator used to move the camera from object to object when not using VR.
    /// </summary>
    public GameObject CameraAnimator;

    /// <summary>
    /// Set this to true to enable realtime shadows at high quality.
    /// </summary>
    public bool UseModQualitySettings = true;

    /// <summary>
    /// A list of transforms where mod holdables can be spawned
    /// </summary>
    public List<KMHoldableSpawnPoint> HoldableSpawnPoints;
}
