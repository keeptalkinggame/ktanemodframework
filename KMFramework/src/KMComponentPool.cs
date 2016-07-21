using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// A ComponentPool is a collection of Module Types.
/// The generator will pick Count times from this list and instantiate a component of the chosen type.
/// </summary>
[Serializable]
public class KMComponentPool
{
    /// <summary>
    /// Controls where this pool will draw from (e.g. the base game modules, modules from mods, or both).
    /// </summary>
    [Flags]
    public enum ComponentSource
    {
        Base = 1,
        Mods = 2
    }

    /// <summary>
    /// Controls whether the modules will be chosen dynamically at runtime from whatever modules are loaded (based on the ComponentSource). 
    /// Set to "None" to select specific module types.
    /// </summary>
    public enum SpecialComponentTypeEnum
    {
        None,
        ALL_SOLVABLE,
        ALL_NEEDY
    }

    /// <summary>
    /// The module types in the base game.
    /// </summary>
    public enum ComponentTypeEnum
    {
        Empty,
        Timer,
        Wires,
        BigButton,
        Keypad,
        Simon,
        WhosOnFirst,
        Memory,
        Morse,
        Venn,
        WireSequence,
        Maze,
        Password,
        NeedyVentGas,
        NeedyCapacitor,
        NeedyKnob
    }

    /// <summary>
    /// How many components from this pool should be selected.
    /// </summary>
    public int Count;

    /// <summary>
    /// Controls where components can come from (either the base game, mods, or both).
    /// </summary>
    public ComponentSource AllowedSources = ComponentSource.Base;

    /// <summary>
    /// The list of component types, not including any calculated at runtime special
    /// types, like ALL_SOLVABLE. Use GetComponentTypes to get the calculated list.
    /// </summary>
    public List<ComponentTypeEnum> ComponentTypes;

    /// <summary>
    /// Special types which are calculated at runtime, such as ALL_SOLVABLE.
    /// </summary>
    public SpecialComponentTypeEnum SpecialComponentType;

    /// <summary>
    /// A list of mod types to be included in the pool, if they exist.
    /// </summary>
    public List<string> ModTypes;

    public override string ToString()
    {
        if (SpecialComponentType == SpecialComponentTypeEnum.None)
        {
            List<string> componentNames = ComponentTypes.Select(t => t.ToString()).ToList();
            ModTypes = ModTypes.Where(t => !string.IsNullOrEmpty(t)).ToList();
            componentNames.AddRange(ModTypes);

            return String.Format("[{0}] Count: {1}", String.Join(", ",
                componentNames.ToArray<String>()),
                Count);
        }
        else
        {
            return String.Format("[{0}] Count: {1}",
                SpecialComponentType.ToString(),
                Count);
        }
    }
}
