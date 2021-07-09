using UnityEngine;
using System.Collections;

/// <summary>
/// A class for specifying spawn points for holdable objects
/// </summary>
[DisallowMultipleComponent]
public class KMHoldableSpawnPoint : MonoBehaviour
{
    /// <summary>
    /// The X position in the children map for the room, row lengths are 5
    /// </summary>
    public int SelectableIndexX;
    /// <summary>
    /// The Y position in the children map for this room, there are 4 rows in the selectable map
    /// </summary>
    public int SelectableIndexY;
}