using System;
using UnityEngine;

/// <summary>
/// Meta-data describing everything for a mission.
/// </summary>
public class KMMission : ScriptableObject
{
    /// <summary>
    /// Unique identifier for this mission.
    /// </summary>
    public string ID { get { return name; } }

    /// <summary>
    /// The mission name as it appears in the bomb binder.
    /// </summary>
    [Tooltip("The mission name as it appears in the bomb binder.")]
    public String DisplayName = String.Empty;

    /// <summary>
    /// The description shown in the bomb binder.
    /// </summary>
    [TextArea(3, 5)]
    public String Description = String.Empty;

    /// <summary>
    /// Details about how the bomb should be generated for this mission.
    /// </summary>
    public KMGeneratorSetting GeneratorSetting = new KMGeneratorSetting();

    /// <summary>
    /// Controls whether or not all pacing events are enabled.
    /// </summary>
    [Tooltip("Controls whether or not all pacing events are enabled.")]
    public bool PacingEventsEnabled = false;
}
