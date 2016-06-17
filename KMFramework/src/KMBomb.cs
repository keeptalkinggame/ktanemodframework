using UnityEngine;
using System.Collections.Generic;

public class KMBomb : MonoBehaviour
{
    public List<KMBombFace> Faces;
    public List<GameObject> WidgetAreas;
    public Transform visualTransform;
    public float Scale = 0.74f;
    public bool IsHoldable = true;
}
