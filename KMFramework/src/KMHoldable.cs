using UnityEngine;
using System;

public class KMHoldable : MonoBehaviour
{
    public Action OnHold;
    public Action OnHoldAnimationComplete;

    public Action OnLetGo;
    public Action OnLetGoAnimationComplete;

    public float FocusDistance = 0.63f;
}

