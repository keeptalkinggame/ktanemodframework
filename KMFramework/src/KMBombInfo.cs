using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Interface to information about the bomb and its widgets. 
/// Add this component to a module to query properties of the bomb for use in rules.
/// </summary>
public class KMBombInfo : MonoBehaviour
{
    public static string QUERYKEY_GET_SERIAL_NUMBER = "serial";
    public static string QUERYKEY_GET_BATTERIES = "batteries";
    public static string QUERYKEY_GET_INDICATOR = "indicator";
    public static string QUERYKEY_GET_PORTS = "ports";

    public delegate float GetTimeHandler();
    public GetTimeHandler TimeHandler;

    public delegate string GetFormattedTimeHandler();
    public GetFormattedTimeHandler FormattedTimeHandler;

    public delegate int GetStrikesHandler();
    public GetStrikesHandler StrikesHandler;

    public delegate List<string> GetModuleNamesHandler();
    public GetModuleNamesHandler ModuleNamesHandler;

    public delegate List<string> GetSolvableModuleNamesHandler();
    public GetSolvableModuleNamesHandler SolvableModuleNamesHandler;

    public delegate List<string> GetSolvedModuleNamesHandler();
    public GetSolvedModuleNamesHandler SolvedModuleNamesHandler;

    public delegate List<string> GetModuleIDsHandler();
    public GetModuleIDsHandler ModuleIDsHandler;

    public delegate List<string> GetSolvableModuleIDsHandler();
    public GetSolvableModuleIDsHandler SolvableModuleIDsHandler;

    public delegate List<string> GetSolvedModuleIDsHandler();
    public GetSolvedModuleIDsHandler SolvedModuleIDsHandler;

    public delegate List<string> GetWidgetQueryResponsesHandler(string queryKey, string queryInfo);
    public GetWidgetQueryResponsesHandler WidgetQueryResponsesHandler;

    public delegate bool KMIsBombPresent();
    public KMIsBombPresent IsBombPresentHandler;

    public delegate void KMBombSolvedDelegate();
    public KMBombSolvedDelegate OnBombSolved;

    public delegate void KMBombExplodedDelegate();
    public KMBombSolvedDelegate OnBombExploded;

    /// <returns>Time remaining on the bomb, in seconds.</returns>
    public float GetTime()
    {
        if (TimeHandler != null)
        {
            return TimeHandler();
        }

        return 0f;
    }

    /// <summary>
    /// Get the text currently displayed on the bomb's timer.
    /// </summary>
    /// <returns></returns>
    public string GetFormattedTime()
    {
        if (FormattedTimeHandler != null)
        {
            return FormattedTimeHandler();
        }

        return string.Empty;
    }

    /// <returns>The number of strikes received by the player this round.</returns>
    public int GetStrikes()
    {
        if (StrikesHandler != null)
        {
            return StrikesHandler();
        }

        return -1;
    }


    /// <returns>A list of the module names on the current bomb.</returns>
    public List<string> GetModuleNames()
    {
        if (ModuleNamesHandler != null)
        {
            return ModuleNamesHandler();
        }

        return new List<string>();
    }

    /// <returns>A list of the solvable module names on the current bomb.</returns>
    public List<string> GetSolvableModuleNames()
    {
        if (SolvableModuleNamesHandler != null)
        {
            return SolvableModuleNamesHandler();
        }

        return new List<string>();
    }

    /// <returns>A list of the solved module names on the current bomb.</returns>
    public List<string> GetSolvedModuleNames()
    {
        if (SolvedModuleNamesHandler != null)
        {
            return SolvedModuleNamesHandler();
        }

        return new List<string>();
    }

    /// <returns>A list of the module IDs on the current bomb. A module ID is "ModuleType" for mod modules and a ComponentType string for base game modules.</returns>
    public List<string> GetModuleIDs()
    {
        if (ModuleIDsHandler != null)
        {
            return ModuleIDsHandler();
        }

        return new List<string>();
    }
    /// <returns>A list of the solvable module IDs on the current bomb. A module ID is "ModuleType" for mod modules and a ComponentType string for base game modules.</returns>
    public List<string> GetSolvableModuleIDs()
    {
        if (SolvableModuleNamesHandler != null)
        {
            return SolvableModuleIDsHandler();
        }

        return new List<string>();
    }

    /// <returns>A list of the solved module IDs on the current bomb. A module ID is "ModuleType" for mod modules and a ComponentType string for base game modules.</returns>
    public List<string> GetSolvedModuleIDs()
    {
        if (SolvedModuleNamesHandler != null)
        {
            return SolvedModuleIDsHandler();
        }

        return new List<string>();
    }


    /// <summary>
    /// Query all widgets on the bomb using the given queryKey. Use this to get information about things like battery count, indicator labels, or
    /// custom information from mod widgets.
    /// 
    /// Be sure to consider all responses when using this information in your rules, as there may be more than one instance of a widget and thus
    /// more than one valid response.
    /// </summary>
    /// <param name="queryKey"></param>
    /// <param name="queryInfo"></param>
    /// <returns>A list of response strings from all widgets.</returns>
    public List<string> QueryWidgets(string queryKey, string queryInfo)
    {
        if (WidgetQueryResponsesHandler != null)
        {
            return WidgetQueryResponsesHandler(queryKey, queryInfo);
        }

        return new List<string>();
    }

    /// <returns>True if there is a bomb present. This will not be the case during non-gameplay scenes.</returns>
    public bool IsBombPresent()
    {
        if (IsBombPresentHandler != null)
        {
            return IsBombPresentHandler();
        }

        return false;
    }
}
