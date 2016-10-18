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
    /// The set of anchors that can be used for the timer
    /// All anchors in TimerAnchors must also be in the Anchors list
    /// If not TimerAnchors are found a random Anchor from the Anchors list will be chosen
    /// </summary>
    public List<Transform> TimerAnchors;

    /// <summary>
    /// Visual models of the backing (e.g. foam) spawned behind modules, in the same order as Anchors.
    /// </summary>
    public List<KMModuleBacking> Backings;
}
