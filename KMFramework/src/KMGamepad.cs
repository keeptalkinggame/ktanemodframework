using UnityEngine;

[DisallowMultipleComponent]
public class KMGamepad :MonoBehaviour
{
    /// <summary>
    /// Enumeration of gamepad buttons using XBox gamepad naming conventions
    /// </summary>
    public enum ButtonEnum { A, B, X, Y, LB, RB, START, LEFT, RIGHT, UP, DOWN };

    /// <summary>
    /// Enumeration of gamepad axes using XBox gamepad naming conventions
    /// </summary>
    public enum AxisEnum { LEFT_X, LEFT_Y, RIGHT_X, RIGHT_Y, LT, RT };

    /// <summary>
    /// Get a specified axis value 
    /// </summary>
    public float GetAxisValue(AxisEnum axis, int controller = 0)
    {
        if(OnGetAxisValue != null)
        {
            return OnGetAxisValue(axis, controller);
        }

        return 0.0f;
    }

    /// <summary>
    /// Get whether a specified button received a buttondown event this frame 
    /// </summary>
    public bool GetButtonDown(ButtonEnum button, int controller = 0)
    {
        if (OnGetButtonDown != null)
        {
            return OnGetButtonDown(button, controller);
        }

        return false;
    }

    /// <summary>
    /// Get whether a specified button received a buttonup event this frame 
    /// </summary>
    public bool GetButtonUp(ButtonEnum button, int controller = 0)
    {
        if (OnGetButtonUp != null)
        {
            return OnGetButtonUp(button, controller);
        }

        return false;
    }

    #region Delegates
    /// <summary>
    /// Delegate type for checking axis value
    /// </summary>
    public delegate float KMOnGetAxisValueDelegate(AxisEnum axis, int controller = 0);
    /// <summary>
    /// Delegate type for checking buttonup event
    /// </summary>
    public delegate bool KMOnGetButtonDownDelegate(ButtonEnum button, int controller = 0);
    /// <summary>
    /// Delegate type for checking buttonup event
    /// </summary>
    public delegate bool KMOnGetButtonUpDelegate(ButtonEnum button, int controller = 0);
    #endregion

    #region DO NOT USE IN MOD
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to hook into the controller.
    /// </summary>
    public KMOnGetAxisValueDelegate OnGetAxisValue;
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to hook into the controller.
    /// </summary>
    public KMOnGetButtonDownDelegate OnGetButtonDown;
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to hook into the controller.
    /// </summary>
    public KMOnGetButtonUpDelegate OnGetButtonUp;
    #endregion
}
