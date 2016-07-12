using UnityEngine;

public class KMGameCommands : MonoBehaviour
{
    public delegate void KMStartMissionCommand(string id, string seed);
    public KMStartMissionCommand OnStartMission;

    public delegate void KMCauseStrikeDelegate(string reason);
    public KMCauseStrikeDelegate OnCauseStrike;

    public delegate void KMTriggerDistractionDelegate(string distractionId, string options);
    public KMTriggerDistractionDelegate OnTriggerDistraction;

    public void StartMission(string id, string seed)
    {
        if (OnStartMission != null)
        {
            OnStartMission(id, seed);
        }
    }

    public void CauseStrike(string reason)
    {
        if (OnCauseStrike != null)
        {
            OnCauseStrike(reason);
        }
    }

    public void TriggerDistraction(string distractionId, string options)
    {
        if (OnTriggerDistraction != null)
        {
            OnTriggerDistraction(distractionId, options);
        }
    }
}