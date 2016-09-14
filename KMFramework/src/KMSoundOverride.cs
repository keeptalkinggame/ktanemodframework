using UnityEngine;

/// <summary>
/// Add this component to a prefab to specify an AudioClip that should be played whenever the
/// given sound effect is triggered instead of the original game's audio.
/// </summary>
public class KMSoundOverride : MonoBehaviour
{
    public enum SoundEffect
    {
        ButtonPress,
        ButtonRelease,
        BigButtonPress,
        BigButtonRelease,
        WireSnip,
        Strike,
        AlarmClockBeep,
        AlarmClockSnooze,
        Switch,
        GameOverFanfare,
        BombDefused,
        BriefcaseOpen,
        BriefcaseClose,
        CorrectChime,
        BombExplode,
        NormalTimerBeep,
        FastTimerBeep,
        FastestTimerBeep,
        LightBuzz,
        LightBuzzShort,
        Stamp,
        TypewriterKey,
        NeedyActivated,
        WireSequenceMechanism,
        SelectionTick,
        PageTurn,
        DossierOptionPressed,
        FreeplayDeviceDrop,
        BombDrop,
        MenuDrop,
        BinderDrop,
        MenuButtonPressed,
        TitleMenuPressed,
        CapacitorPop,
        EmergencyAlarm,
        NeedyWarning
    };

    /// <summary>
    /// The sound effect in the base game to replace.
    /// </summary>
    public SoundEffect OverrideEffect;

    /// <summary>
    /// The AudioClip to be played instead of the base game's sound.
    /// </summary>
    public AudioClip AudioClip;

    /// <summary>
    /// If you want to provide additional variants that will be chosen randomly to play for this override
    /// </summary>
    public AudioClip[] AdditionalVariants;
}
