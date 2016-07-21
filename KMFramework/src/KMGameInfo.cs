using UnityEngine;

/// <summary>
/// Interface to get notified of game state changes.
/// </summary>
public class KMGameInfo : MonoBehaviour
{
    public enum State { Gameplay, Setup, PostGame, Transitioning, Unlock, Quitting }

    public delegate void KMStateChangeDelegate(State state);
    public KMStateChangeDelegate OnStateChange;
}