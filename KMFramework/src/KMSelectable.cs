using UnityEngine;
using System;

/// <summary>
/// The interface to all interactive elements in the game. Set this up to allow an object to be
/// selected, interacted with, and handle input.
/// </summary>
[DisallowMultipleComponent]
public class KMSelectable : MonoBehaviour
{
    /// <summary>
    /// Delegate type for interactions, return is whether it should drill in to children
    /// </summary>
    public delegate bool OnInteractHandler();

    /// <summary>
    /// Delegate type for cancelling, return is whether it should drill out to parent
    /// </summary>
    public delegate bool OnCancelHandler();

    /// <summary>
    /// The parent of this selectable
    /// </summary>
    public KMSelectable Parent;

    /// <summary>
    /// This is the list of child selectables. 
    /// Order is important as it is treated as a grid with row length defined by ChildRowLength.
    /// </summary>
    public KMSelectable[] Children;

    /// <summary>
    /// Determines if this selectable is essentially a container, currently used for bomb faces
    /// </summary>
    public bool IsPassThrough;

    /// <summary>
    /// This is the number of selectables per row for gamepad controls
    /// </summary>
    public int ChildRowLength;

    /// <summary>
    /// Sets the object with a highlight mesh for this selectable
    /// </summary>
    public KMHighlightable Highlight;

    /// <summary>
    /// If you want to set the interaction colliders for mouse to something other than the highlight
    /// you can set them here.
    /// </summary>
    public Collider[] SelectableColliders;

    /// <summary>
    /// Allows you to set a particular child as the default index for gamepad controls
    /// </summary>
    public int DefaultSelectableIndex = 0;

    /// <summary>
    /// Called whenever this selectable becomes the current selectable.
    /// CAUTION This behaves unintuitively, probably better to use OnHighlight or OnFocus instead
    /// </summary>
    public Action OnSelect;

    /// <summary>
    /// Called whenever this selectable stops being the current selectable
    /// CAUTION This behaves unintuitively, probably better to use OnHighlightEnded or OnDefocus instead
    /// </summary>
    public Action OnDeselect;

    /// <summary>
    /// Called when player backs out of this selectable, an example would be zooming out of a module
    /// </summary>
    public OnCancelHandler OnCancel;

    /// <summary>
    /// Called when player interacts with this selectable. Done on button down
    /// Returns whether or not it should try to drill to children
    /// </summary>
    public OnInteractHandler OnInteract;

    /// <summary>
    /// Called when a player is interacting with this selectable and releases the mouse or controller button
    /// </summary>
    public Action OnInteractEnded;

    /// <summary>
    /// Called when the highlight is turned on, OnSelect is probably more appropriate for most things
    /// </summary>
    public Action OnHighlight;

    /// <summary>
    /// Called when the highlight is turned off
    /// </summary>
    public Action OnHighlightEnded;

    /// <summary>
    /// Called when a module is focused, this is when it is interacted with from the bomb face level and this module's children can be selected
    /// </summary>
    public Action OnFocus;

    /// <summary>
    /// Called when a module is defocused, this is when a different selectable becomes the focus or the module has been backed out of
    /// </summary>
    public Action OnDefocus;

    /// <summary>
    /// Called when player pulls selection stick left while this selectable is focused
    /// </summary>
    public Action OnLeft;

    /// <summary>
    /// Called when player pulls selection stick right while this selectable is focused
    /// </summary>
    public Action OnRight;

    /// <summary>
    /// Determines whether gamepad selection should wrap around left/right
    /// </summary>
    public bool AllowSelectionWrapX = false;

    /// <summary>
    /// Determines whether gamepad selection should wrap around up/down
    /// </summary>
    public bool AllowSelectionWrapY = false;

    /// <summary>
    /// Adds bomb movement and controller vibration on interaction, amount is based on the modifier
    /// </summary>
    public void AddInteractionPunch(float intensityModifier = 1.0f)
    {
        if(OnInteractionPunch != null)
        {
            OnInteractionPunch(intensityModifier);
        }
    }

    /// <summary>
    /// Notifies the game that the children list has been updated
    /// Selects the child specified as the current selectable
    /// </summary>
    public void UpdateChildren(KMSelectable childToSelect = null)
    {
        if (OnUpdateChildren != null)
        {
            OnUpdateChildren(childToSelect);
        }
    }

    /// <summary>
    /// Forces highlight to be selection highlight, this is yellow in game
    /// Should be used when interaction will drill down to child selectables
    /// </summary>
    public bool ForceSelectionHighlight = false;

    /// <summary>
    /// Forces highlight to be interaction highlight, this is red in game
    /// Should be used when interaction will trigger a behavior
    /// </summary>
    public bool ForceInteractionHighlight = false;

    #region Delegates
    /// <summary>
    /// Delegate type for adding bomb movement and controller vibration on interaction
    /// </summary>
    public delegate void KMOnAddInteractionPunchDelegate(float intensityModifier = 1.0f);
    
    /// <summary>
    /// Delegate type for updating the children map
    /// </summary>
    public delegate void KMOnUpdateChildrenDelegate(KMSelectable childToSelect = null);
    #endregion

    #region DO NOT USE IN MOD
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to hook into the selectable.
    /// </summary>
    public KMOnAddInteractionPunchDelegate OnInteractionPunch;
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to hook into the selectable.
    /// </summary>
    public KMOnUpdateChildrenDelegate OnUpdateChildren;
    #endregion
}
