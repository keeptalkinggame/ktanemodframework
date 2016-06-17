using UnityEngine;
using System;

public class KMSelectable : MonoBehaviour
{
    public delegate bool OnInteractHandler();

    public KMSelectable Parent;
    public KMSelectable[] Children;
    public bool IsPassThrough;
    public int ChildRowLength;
    public KMHighlightable Highlight;
    public Collider SelectableArea;
    public int DefaultSelectableIndex = 0;

    public Action OnSelect;
    public Action OnCancel;
    public OnInteractHandler OnInteract;
    public Action OnHighlight;
    public Action OnLeft;
    public Action OnRight;
}
