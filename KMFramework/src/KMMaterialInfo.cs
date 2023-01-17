using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// This component is added during assetbundle build to any game objects that have material components
/// This should not be used by modders but is instead used to mitigate potential future incompatibilities in Unity
/// </summary>
[HelpURL("https://github.com/Qkrisi/ktanemodkit/wiki/KMMaterialInfo")]
[AddComponentMenu("")]
public class KMMaterialInfo : MonoBehaviour
{
    /// <summary>
    /// The name of the shader used by the material on this game object
    /// </summary>
    public List<string> ShaderNames;
}
