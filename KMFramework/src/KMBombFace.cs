using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// A collection of transforms where modules can be instantiated along with their backings.
/// </summary>
public class KMBombFace : MonoBehaviour
{
    /// <summary>
    /// Module spawn points.
    /// </summary>
    public List<Transform> Anchors;

    /// <summary>
    /// Visual models of the backing (e.g. foam) spawned behind modules, in the same order as Anchors.
    /// </summary>
    public List<KMModuleBacking> Backings;
}
