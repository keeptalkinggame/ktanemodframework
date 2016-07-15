using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Meta-data that controls how custom missions are listed in the bomb binder.
/// </summary>
public class KMMissionTableOfContents : ScriptableObject
{
    /// <summary>
    /// Describes a list of missions along with an appropriate header.
    /// </summary>
    [Serializable]
    public struct Section
    {
        /// <summary>
        /// The section header used in the bomb binder. Example: "Challenging", "Exotic".
        /// </summary>
        public string Title;

        /// <summary>
        /// Custom missions from this mod to be included in the section.
        /// </summary>
        public List<string> MissionIDs;
    }

    /// <summary>
    /// Title of the entire table of contents. Example: "Gary's Missions".
    /// </summary>
    public string Title;

    /// <summary>
    /// An ordered list of sections to include in the bomb binder.
    /// </summary>
    public List<Section> Sections;
}