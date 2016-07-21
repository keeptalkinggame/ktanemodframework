using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


/// <summary>
/// Everything needed to generate a single bomb.
/// </summary>
[Serializable]
public class KMGeneratorSetting
{
    [Tooltip("Initial value for the timer when the bomb is activated.")]
    public float TimeLimit;

    [Tooltip("The number of strikes at which the bomb explodes")]
    public int NumStrikes;

    [Tooltip("Time, in seconds, which must elapse before any unactivated Needy modules are automatically activated.")]
    public int TimeBeforeNeedyActivation;

    /// <summary>
    /// Force modules to be placed only on the front face. By default this will limit the module count to 5 (+1 for the timer).
    /// Useful in rare circumstances where you wish to generate a bomb with a few modules and guarantee that they will all
    /// be visibile simultaneously.
    /// </summary>
    [Tooltip("Force modules to be placed only on the front face.")]
    public bool FrontFaceOnly;

    //All module pools will be used when generating a bomb
    public List<KMComponentPool> ComponentPools;

    public KMGeneratorSetting()
    {
        ComponentPools = new List<KMComponentPool>();
        NumStrikes = 3;
        TimeLimit = 300;
        TimeBeforeNeedyActivation = 90;
    }

    public int GetComponentCount()
    {
        int count = 0;

        foreach (KMComponentPool pool in ComponentPools)
        {
            count += pool.Count;
        }

        return count;
    }

    public override string ToString()
    {
        String str = String.Format("Time: {0}, NumStrikes: {1}", TimeLimit, NumStrikes);

        str += String.Format("\n{0} Pools:\n", ComponentPools.Count);

        foreach (KMComponentPool pool in ComponentPools)
        {
            str += String.Format("{0}\n", pool.ToString());
        }

        return str;
    }
}
