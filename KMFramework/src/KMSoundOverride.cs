using UnityEngine;

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

    public SoundEffect OverrideEffect;
    public AudioClip AudioClip;
}
