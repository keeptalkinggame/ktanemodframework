using UnityEngine;

public class KMGameInfo : MonoBehaviour
{
    public enum State { Gameplay, Setup, PostGame, Transitioning, Unlock, Quitting }

    public delegate void KMStateChangeDelegate(State state);
    public KMStateChangeDelegate OnStateChange;
}