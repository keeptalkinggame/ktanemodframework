using UnityEngine;
using System.Collections.Generic;

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

    public delegate List<string> GetWidgetQueryResponsesHandler(string queryKey, string queryInfo);
    public GetWidgetQueryResponsesHandler WidgetQueryResponsesHandler;

    public delegate bool KMIsBombPresent();
    public KMIsBombPresent IsBombPresentHandler;

    public delegate void KMBombSolvedDelegate();
    public KMBombSolvedDelegate OnBombSolved;

    public delegate void KMBombExplodedDelegate();
    public KMBombSolvedDelegate OnBombExploded;

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

    public int GetStrikes()
    {
        if (StrikesHandler != null)
        {
            return StrikesHandler();
        }

        return -1;
    }

    public List<string> GetModuleNames()
    {
        if (ModuleNamesHandler != null)
        {
            return ModuleNamesHandler();
        }

        return new List<string>();
    }

    public List<string> GetSolvableModuleNames()
    {
        if (SolvableModuleNamesHandler != null)
        {
            return SolvableModuleNamesHandler();
        }

        return new List<string>();
    }

    public List<string> GetSolvedModuleNames()
    {
        if (SolvedModuleNamesHandler != null)
        {
            return SolvedModuleNamesHandler();
        }

        return new List<string>();
    }

    public List<string> QueryWidgets(string queryKey, string queryInfo)
    {
        if (WidgetQueryResponsesHandler != null)
        {
            return WidgetQueryResponsesHandler(queryKey, queryInfo);
        }

        return new List<string>();
    }

    public bool IsBombPresent()
    {
        if (IsBombPresentHandler != null)
        {
            return IsBombPresentHandler();
        }

        return false;
    }
}
