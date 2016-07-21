using UnityEngine;

/// <summary>
/// This class acts as a proxy for the game's needy bomb module. Don't subclass but instead add it as a component.
/// </summary>
public class KMNeedyModule : MonoBehaviour
{
    /// <summary>
    /// The amount of time on the needy timer whenever this module is activated.
    /// </summary>
    public float CountdownTime = 40f;

    /// <summary>
    /// The identifier for the module as referenced in missions. e.g. "BigButton"
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
    /// Do not have your needy module start counting down until this activation happens.
    /// </summary>
    public KMNeedyActivationEvent OnNeedyActivation;

    /// <summary>
    /// This is usually when the bomb has been solved or has exploded. You will need to stop your countdown.
    /// </summary>
    public KMNeedyDeactivationEvent OnNeedyDeactivation;

    /// <summary>
    /// Handle when timer runs out, usually by giving a strike.
    /// </summary>
    public KMTimerExpiredEvent OnTimerExpired;

    /// <summary>
    /// Event is fired when the bomb has been activated and the timer has started.
    /// </summary>
    public KMModuleActivateEvent OnActivate;

    /// <summary>
    /// Call this when the needy module has been correctly satisified and should be temporarily put to rest.
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
    public delegate void KMNeedyActivationEvent();
    public delegate void KMNeedyDeactivationEvent();
    public delegate void KMTimerExpiredEvent();

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
