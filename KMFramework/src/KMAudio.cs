using UnityEngine;

/// <summary>
/// Component that provides an interface to the game's audio system. Allows playing of sounds in a way that will
/// respect volume settings and gameplay events. Can be used to play existing sounds or sounds added in this mod.
/// </summary>
public class KMAudio : MonoBehaviour
{
    public delegate void PlaySoundAtTransformHandler(string name, Transform transform);
    public PlaySoundAtTransformHandler HandlePlaySoundAtTransform;

    public delegate void PlayGameSoundAtTransformHandler(KMSoundOverride.SoundEffect sound, Transform transform);
    public PlayGameSoundAtTransformHandler HandlePlayGameSoundAtTransform;

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
}
