using UnityEngine;
using System;

/// <summary>
/// Interface to define a holdable object that can be picked up by motion controls
/// Should add a rigidbody or a default one will be created
/// </summary>
[DisallowMultipleComponent]
public class KMHoldable : MonoBehaviour
{
    /// <summary>
    /// Position to hold object when picked up
    /// </summary>
    public Vector3 targetPosition = new Vector3(0.3f, 1.25f, -1.25f);
    
    /// <summary>
    /// Default rotation of object when held
    /// </summary>
    public Vector3 targetRotation = new Vector3(13.5f, 0f, 0f);

    /// <summary>
    /// Enumeration of controller buttons
    /// </summary>
    public enum ButtonEnum { BUTTON1, BUTTON2, TOUCHPAD };

    /// <summary>
    /// Enumeration of controller axes
    /// </summary>
    public enum AxisEnum { X, Y, TRIGGER, GRIP };

    /// <summary>
    /// Enumeration of holdable availibilities
    /// </summary>
    public enum HoldableAvailabilityEnum { SETUP, GAMEPLAY, ALL, NONE};

    /// <summary>
    /// Indicates in which room the holdable will be available
    /// </summary>
    public HoldableAvailabilityEnum HoldableAvailability = HoldableAvailabilityEnum.NONE;

    /// <summary>
    /// Get a specified axis value for the controller holding this object
    /// </summary>
    public float GetAxisValue(AxisEnum axis, int controller = 0)
    {
        if (OnGetAxisValue != null)
        {
            return OnGetAxisValue(axis);
        }

        return 0.0f;
    }

    /// <summary>
    /// Get whether a specified button is currently held for the controller holding this object
    /// </summary>
    public bool GetButton(ButtonEnum button)
    {
        if (OnGetButton != null)
        {
            return OnGetButton(button);
        }

        return false;
    }

    /// <summary>
    /// Gets the transform for the anchor on the controller holding this object
    /// </summary>
    public Transform GetAnchorTransform()
    {
        if (OnGetAnchorTransform != null)
        {
            return OnGetAnchorTransform();
        }

        return null;
    }

    #region Delegates
    /// <summary>
    /// Delegate type for checking axis value
    /// </summary>
    public delegate float KMOnGetAxisValueDelegate(AxisEnum axis);
    /// <summary>
    /// Delegate type for checking buttonup event
    /// </summary>
    public delegate bool KMOnGetButtonDelegate(ButtonEnum button);
    /// <summary>
    /// Delegate type for checking buttonup event
    /// </summary>
    public delegate Transform KMOnGetAnchorDelegate();
    #endregion

    #region DO NOT USE IN MOD
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to hook into the controller.
    /// </summary>
    public KMOnGetAxisValueDelegate OnGetAxisValue;
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to hook into the controller.
    /// </summary>
    public KMOnGetButtonDelegate OnGetButton;
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to hook into the controller.
    /// </summary>
    public KMOnGetAnchorDelegate OnGetAnchorTransform;
    #endregion
}

