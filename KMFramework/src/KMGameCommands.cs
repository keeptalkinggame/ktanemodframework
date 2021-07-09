using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Interface to directly execute actions related to the game or controlling game flow.
/// </summary>
[DisallowMultipleComponent]
public class KMGameCommands : MonoBehaviour
{
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
    /// Launches a custom KMMission with the mission id set to 'custom'
    /// </summary>
    /// <param name="mission"></param>
    /// <param name="seed"></param>
    public void StartMission(KMMission mission, string seed)
    {
        if (OnStartCustomMission != null)
        {
            OnStartCustomMission(mission, seed);
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

    /// <summary>
    /// Gets the list of all bombs currently available
    /// </summary>
    public List<KMBomb> GetBombs()
    {
        if (OnGetBombs != null)
        {
            return OnGetBombs();
        }

        return new List<KMBomb>();
    }

    /// <summary>
    /// Creates and returns a new bomb with 
    /// </summary>
    /// <param name="missionId">The mission id to spawn the bomb based on</param>
    /// <param name="generatorSettings">Generator seetings that will be used if missionId is empty or null </param>
    /// <param name="spawnPoint">A gameobject whose transform will determine where the bomb spawns </param>
    /// <param name="seed">The seed used to generate the bomb, currently this must parse to an int </param>
    public KMBomb CreateBomb(string missionId, KMGeneratorSetting generatorSettings, GameObject spawnPoint, string seed)
    {
        if (OnCreateBomb != null)
        {
            return OnCreateBomb(missionId, generatorSettings, spawnPoint, seed);
        }
        return null;
    }

    /// <summary>
    /// Attempts to remove a solved bomb from play, may fail if bomb not found or only one bomb remaining and not freeplay mode
    /// </summary>
    public bool RemoveSolvedBomb(KMBomb bomb)
    {
        if (OnRemoveSolvedBomb != null)
        {
            return OnRemoveSolvedBomb(bomb);
        }
        return false;
    }

    #region Delegates
    /// <summary>
    /// Delegate type starting mission with id
    /// </summary>
    public delegate void KMStartMissionCommand(string id, string seed);
    /// <summary>
    /// Delegate type starting mission with custom settings
    /// </summary>
    public delegate void KMStartCustomMissionCommand(KMMission mission, string seed);
    /// <summary>
    /// Delegate type causing a strike
    /// </summary>
    public delegate void KMCauseStrikeDelegate(string reason);
    /// <summary>
    /// Delegate type for getting the list of all bombs
    /// </summary>
    public delegate List<KMBomb> GetBombsDelegate();
    /// <summary>
    /// Delegate type for creating a bomb
    /// </summary>
    public delegate KMBomb CreateBombDelegate(string missionId, KMGeneratorSetting generatorSettings, GameObject spawnPoint, string seed);
    /// <summary>
    /// Delegate type for removing a bomb
    /// </summary>
    public delegate bool RemoveSolvedBombDelegate(KMBomb bomb);
    #endregion

    #region DO NOT USE IN MOD
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to start a mission.
    /// </summary>
    public KMStartMissionCommand OnStartMission;
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to start a mission.
    /// </summary>
    public KMStartCustomMissionCommand OnStartCustomMission;
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to cause a strike.
    /// </summary>
    public KMCauseStrikeDelegate OnCauseStrike;
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to retrieve the list of bombs
    /// </summary>
    public GetBombsDelegate OnGetBombs;
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to create a bomb
    /// </summary>
    public CreateBombDelegate OnCreateBomb;
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to remove a bomb
    /// </summary>
    public RemoveSolvedBombDelegate OnRemoveSolvedBomb;
    #endregion
}