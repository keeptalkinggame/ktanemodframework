using System;
using UnityEngine;

/// <summary>
/// Component that provides an interface to the game's audio system. Allows playing of sounds in a way that will
/// respect volume settings and gameplay events. Can be used to play existing sounds or sounds added in this mod.
/// </summary>
[HelpURL("https://github.com/Qkrisi/ktanemodkit/wiki/KMAudio")]
[DisallowMultipleComponent]
public class KMAudio : MonoBehaviour
{
    public class KMAudioRef
    {
        public Action StopSound;
    }

    public delegate void PlaySoundAtTransformHandler(string name, Transform transform);
    public PlaySoundAtTransformHandler HandlePlaySoundAtTransform;

    public delegate void PlayGameSoundAtTransformHandler(KMSoundOverride.SoundEffect sound, Transform transform);
    public PlayGameSoundAtTransformHandler HandlePlayGameSoundAtTransform;

    public delegate KMAudioRef PlaySoundAtTransformWithRefHandler(string name, Transform transform, bool loop = true);
    public PlaySoundAtTransformWithRefHandler HandlePlaySoundAtTransformWithRef;

    public delegate KMAudioRef PlayGameSoundAtTransformWithRefHandler(KMSoundOverride.SoundEffect sound, Transform transform);
    public PlayGameSoundAtTransformWithRefHandler HandlePlayGameSoundAtTransformWithRef;

    /// <summary>
    /// Play a sound from this mod at the given transform.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="transform"></param>
    public void PlaySoundAtTransform(string name, Transform transform)
    {
        if (HandlePlaySoundAtTransform != null)
        {
            HandlePlaySoundAtTransform(name, transform);
        }
    }

    /// <summary>
    /// Play an existing game sound (or its override) at the given transform.
    /// </summary>
    /// <param name="sound"></param>
    /// <param name="transform"></param>
    public void PlayGameSoundAtTransform(KMSoundOverride.SoundEffect sound, Transform transform)
    {
        if (HandlePlayGameSoundAtTransform != null)
        {
            HandlePlayGameSoundAtTransform(sound, transform);
        }
    }

    /// <summary>
    /// Play a sound from this mod at the given transform.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="transform"></param>
    /// <returns>A KMAudioRef that can be used to stop sounds early</returns>
    public KMAudioRef PlaySoundAtTransformWithRef(string name, Transform transform)
    {
        if(HandlePlaySoundAtTransformWithRef != null)
        {
            return HandlePlaySoundAtTransformWithRef(name, transform);
        }
        return null;
    }

    /// <summary>
    /// Play an existing game sound (or its override) at the given transform.
    /// </summary>
    /// <param name="sound"></param>
    /// <param name="transform"></param>
    /// <returns>A KMAudioRef that can be used to stop sounds early</returns>
    public KMAudioRef PlayGameSoundAtTransformWithRef(KMSoundOverride.SoundEffect sound, Transform transform)
    {
        if(HandlePlayGameSoundAtTransformWithRef != null)
        {
            return HandlePlayGameSoundAtTransformWithRef(sound, transform);
        }

        return null;
    }
}
