using UnityEngine;

public class KMAudio : MonoBehaviour
{
    public delegate void PlaySoundAtTransformHandler(string name, Transform transform);
    public PlaySoundAtTransformHandler HandlePlaySoundAtTransform;

    public delegate void PlayGameSoundAtTransformHandler(KMSoundOverride.SoundEffect sound, Transform transform);
    public PlayGameSoundAtTransformHandler HandlePlayGameSoundAtTransform;

    public void PlaySoundAtTransform(string name, Transform transform)
    {
        if (HandlePlaySoundAtTransform != null)
        {
            HandlePlaySoundAtTransform(name, transform);
        }
    }

    public void PlayGameSoundAtTransform(KMSoundOverride.SoundEffect sound, Transform transform)
    {
        if (HandlePlayGameSoundAtTransform != null)
        {
            HandlePlayGameSoundAtTransform(sound, transform);
        }
    }
}
