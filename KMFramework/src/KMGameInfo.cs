using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Interface to get information about game and to get notified of game state changes.
/// </summary>
public class KMGameInfo : MonoBehaviour
{
    /// <summary>
    /// An enumeration of game states
    /// </summary>
    public enum State
    {
        /// <summary>
        /// The gameplay state where defusing happens
        /// </summary>
        Gameplay,
        /// <summary>
        /// The setup state in the office where options are chosen
        /// </summary>
        Setup,
        /// <summary>
        /// The state where results are shown
        /// </summary>
        PostGame,
        /// <summary>
        /// No current state, transitioning to a new state
        /// </summary>
        Transitioning,
        /// <summary>
        /// The unlock state where manual verification and tutorial take place
        /// </summary>
        Unlock,
        /// <summary>
        /// Game is exiting
        /// </summary>
        Quitting
    }

    /// <summary>
    /// A structure that contains a module's name and ID
    /// </summary>
    public struct KMModuleInfo
    {
        /// <summary>
        /// The display name of the module
        /// </summary>
        public string DisplayName;
        /// <summary>
        /// The id of the module
        /// </summary>
        public string ModuleId;
        /// <summary>
        /// True if this module is from a mod rather from the game
        /// </summary>
        public bool IsMod;
        /// <summary>
        /// True if this module is needy and cannot be solved
        /// </summary>
        public bool IsNeedy;
        /// <summary>
        /// Returns the module type of built in modules or empty if this is a mod module
        /// </summary>
        public KMComponentPool.ComponentTypeEnum ModuleType;
    }
    
    /// <summary>
    /// Called when game state changes between gameplay, setup, postgame and loading
    /// </summary>
    public KMStateChangeDelegate OnStateChange;

    /// <summary>
    /// Called when alarm clock turns on or off
    /// </summary>
    public KMAlarmClockChangeDelegate OnAlarmClockChange;

    /// <summary>
    /// Called when in game lights change state
    /// </summary>
    public KMLightsChangeDelegate OnLightsChange;

    /// <summary>
    /// Gets information about all available modules that could be used in a bomb
    /// </summary>
    /// <returns>A list of information about available bomb modules</returns>
    public List<KMModuleInfo> GetAvailableModuleInfo()
    {
        if(OnGetAvailableModuleInfo != null)
        {
            return OnGetAvailableModuleInfo();
        }

        return null;
    }

    /// <summary>
    /// Gets the maximum number of bomb modules that can be placed based on which cases are available
    /// </summary>
    /// <returns>The maximum number of bomb modules that can be placed</returns>
    public int GetMaximumBombModules()
    {
        if (OnGetMaximumBombModules != null)
        {
            return OnGetMaximumBombModules();
        }

        return 11;
    }

    #region Delegates
    /// <summary>
    /// Delegate type for state changes
    /// </summary>
    public delegate void KMStateChangeDelegate(State state);

    /// <summary>
    /// Delegate type for alarm clock state change
    /// </summary>
    public delegate void KMAlarmClockChangeDelegate(bool on);

    /// <summary>
    /// Delegate type for change in lights
    /// </summary>
    public delegate void KMLightsChangeDelegate(bool on);

    /// <summary>
    /// Delegate type for getting info on available modules
    /// </summary>
    public delegate List<KMModuleInfo> KMGetAvailableModuleInfoDelgate();
    
    /// <summary>
    /// Delegate type for getting the total number of modules that can be placed
    /// </summary>
    public delegate int KMGetMaximumBombModulesDelgate();
    #endregion

    #region DO NOT USE IN MOD
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to get available module info
    /// </summary>
    public KMGetAvailableModuleInfoDelgate OnGetAvailableModuleInfo;
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game for getting the total number of modules that can be placed
    /// </summary>
    public KMGetMaximumBombModulesDelgate OnGetMaximumBombModules;
    #endregion
}