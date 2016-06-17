using UnityEngine;

public class KMHighlightable : MonoBehaviour
{
    public Vector3 HighlightScale = Vector3.zero;

    [Range(0.0F, 0.01f)]
    public float OutlineAmount = 0f;
}
