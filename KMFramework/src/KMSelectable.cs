using UnityEngine;
using System;

/// <summary>
/// The interface to all interactive elements in the game. Set this up to allow an object to be
/// selected, interacted with, and handle input.
/// </summary>
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
