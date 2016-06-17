using UnityEngine;

public class KMAudio : MonoBehaviour
{
    public delegate void PlaySoundAtTransformHandler(string name, Transform transform);
    public PlaySoundAtTransformHandler HandlePlaySoundAtTransform;

    public void PlaySoundAtTransform(string name, Transform transform)
    {
        if (HandlePlaySoundAtTransform != null)
        {
            HandlePlaySoundAtTransform(name, transform);
        }
    }
}
