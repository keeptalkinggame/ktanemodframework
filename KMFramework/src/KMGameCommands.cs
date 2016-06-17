using UnityEngine;

public class KMGameCommands : MonoBehaviour
{
    public delegate void KMStartMissionCommand(string id, string seed);

    public KMStartMissionCommand OnStartMission;

    public void StartMission(string id, string seed)
    {
        if (OnStartMission != null)
        {
            OnStartMission(id, seed);
        }
    }
}
