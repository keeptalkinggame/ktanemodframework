using UnityEngine;

/// <summary>
/// Interface to directly execute actions related to the game or controlling game flow.
/// </summary>
public class KMGameCommands : MonoBehaviour
{
    public delegate void KMStartMissionCommand(string id, string seed);
    public KMStartMissionCommand OnStartMission;

    public delegate void KMCauseStrikeDelegate(string reason);
    public KMCauseStrikeDelegate OnCauseStrike;

    /// <summary>
    /// Launches a mission using the given mission id as well as the random seed provided. Useful for triggering deterministic rounds (e.g. for a tournament).
    /// </summary>
    /// <param name="id"></param>
    /// <param name="seed"></param>
    public void StartMission(string id, string seed)
    {
        if (OnStartMission != null)
        {
            OnStartMission(id, seed);
        }
    }

    /// <summary>
    /// Cause a strike on the bomb for whatever reason you deem is appropriate.
    /// </summary>
    /// <param name="reason"></param>
    public void CauseStrike(string reason)
    {
        if (OnCauseStrike != null)
        {
            OnCauseStrike(reason);
        }
    }
}