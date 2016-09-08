using UnityEngine;

/// <summary>
/// Interface to get notified of game state changes.
/// </summary>
public class KMGameInfo : MonoBehaviour
{
    public enum State { Gameplay, Setup, PostGame, Transitioning, Unlock, Quitting }

    /// <summary>
    /// Delegate type for state changes
    /// </summary>
    public delegate void KMStateChangeDelegate(State state);

    /// <summary>
    /// Delegate type for alarm clock state change
    /// </summary>
    public delegate void KMAlarmClockChangeDelegate(bool on);

    /// <summary>
    /// Delegate type for change in lights
    /// </summary>
    public delegate void KMLightsChangeDelegate(bool on);

    /// <summary>
    /// Called when game state changes between gameplay, setup, postgame and loading
    /// </summary>
    public KMStateChangeDelegate OnStateChange;

    /// <summary>
    /// Called when alarm clock turns on or off
    /// </summary>
    public KMAlarmClockChangeDelegate OnAlarmClockChange;

    /// <summary>
    /// Called when in game lights change state
    /// </summary>
    public KMLightsChangeDelegate OnLightsChange;
}