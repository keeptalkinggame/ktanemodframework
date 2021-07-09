using UnityEngine;

/// <summary>
/// This class acts as a proxy for the game's needy bomb module. Don't subclass but instead add it as a component.
/// </summary>
[DisallowMultipleComponent]
public class KMBombModule : MonoBehaviour
{
    /// <summary>
    /// The identifier for the module as referenced in missions. e.g. "BigButton"
    /// Also known as a "Module ID".
    /// </summary>
    public string ModuleType;

    /// <summary>
    /// The nice display name shown to players. e.g. "The Button"
    /// </summary>
    public string ModuleDisplayName;

    /// <summary>
    /// Set to true to only allow this module to be placed on the same face as the timer. 
    /// Useful when the rules involve the timer in some way (like the Big Button), but should be used sparingly
    /// as it limits generation possibilities.
    /// </summary>
    public bool RequiresTimerVisibility;

    /// <summary>
    /// Event is fired when the bomb has been activated and the timer has started.
    /// </summary>
    public KMModuleActivateEvent OnActivate;

    /// <summary>
    /// Call this when the entire module has been solved.
    /// </summary>
    public void HandlePass()
    {
        if (OnPass != null)
        {
            OnPass();
        }
    }

    /// <summary>
    /// Call this on any mistake that you want to cause a bomb strike.
    /// </summary>
    public void HandleStrike()
    {
        if (OnStrike != null)
        {
            OnStrike();
        }
    }

    /// <summary>
    /// Returns the random seed used to generate the rules for this game. Not currently used.
    /// </summary>
    /// <returns></returns>
    public int GetRuleGenerationSeed()
    {
        if (GetRuleGenerationSeedHandler != null)
        {
            return GetRuleGenerationSeedHandler();
        }

        return -1;
    }

    #region Delegates
    public delegate bool KMPassEvent();
    public delegate bool KMStrikeEvent();

    public delegate void KMModuleActivateEvent();
    public delegate void KMModuleDeactivateEvent();

    public delegate int KMRuleGenerationSeedDelegate();
    #endregion

    #region DO NOT USE IN MOD
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to hook into the bomb.
    /// </summary>
    public KMStrikeEvent OnStrike;
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to hook into the bomb.
    /// </summary>
    public KMPassEvent OnPass;
    /// <summary>
    /// DO NOT USE IN MOD. Used by the game to hook into the bomb.
    /// </summary>
    public KMRuleGenerationSeedDelegate GetRuleGenerationSeedHandler;
    #endregion
}
