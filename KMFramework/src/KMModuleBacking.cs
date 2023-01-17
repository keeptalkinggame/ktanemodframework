using UnityEngine;

/// <summary>
/// Visual models of the foam behind modules. Modules that have holes or recesses can have parts of this
/// visible.
/// </summary>
[HelpURL("https://github.com/Qkrisi/ktanemodkit/wiki/KMModuleBacking")]
[DisallowMultipleComponent]
public class KMModuleBacking : MonoBehaviour
{
    /// <summary>
    /// The visual model spawned when a module in this position has RequiresDeepBacking = true
    /// </summary>
    public GameObject BackingDeep;

    /// <summary>
    /// The visual model spawned when a module in this position has RequiresDeepBacking = false
    /// </summary>
    public GameObject BackingNormal;
}
