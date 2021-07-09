using UnityEngine;

/// <summary>
/// Add this component to create a highlight at runtime based on this object's renderer.
/// </summary>
[DisallowMultipleComponent]
public class KMHighlightable : MonoBehaviour
{
    /// <summary>
    /// Set this to non-zero to use a custom highlight scale. Otherwise, leave it at Vector3.zero for default scaling.
    /// </summary>
    public Vector3 HighlightScale = Vector3.zero;

    [Range(0.0F, 0.01f)]
    public float OutlineAmount = 0f;
}
