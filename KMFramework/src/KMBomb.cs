using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Component representing the bomb visual, including the faces upon which modules are placed as well
/// as the areas for spawning widgets.
/// </summary>
public class KMBomb : MonoBehaviour
{
    public List<KMBombFace> Faces;
    public List<GameObject> WidgetAreas;
    public Transform visualTransform;
    public float Scale = 0.74f;
    public bool IsHoldable = true;
}
