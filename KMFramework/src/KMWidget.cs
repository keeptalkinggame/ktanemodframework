using UnityEngine;

/// <summary>
/// A proxy for the game's Widget class, which is a non-interactive, but queryable, element that can be added around the bombs. Don't subclass but instead add it as a component.
/// E.g. serial number, indicator light, ports. 
/// </summary>
public class KMWidget : MonoBehaviour
{
    /// <summary>
    /// The horizontal size of the widget. Usually 1 or 2 units.
    /// </summary>
    public int SizeX;

    /// <summary>
    /// The vertical size of the widget. Usually 1 or 2 units.
    /// </summary>
    public int SizeZ;

    public delegate void KMWidgetActivateDelegate();
    public KMWidgetActivateDelegate OnWidgetActivate;

    public delegate string KMWidgetQueryDelegate(string queryKey, string queryInfo);
    public KMWidgetQueryDelegate OnQueryRequest;

    public static Vector3 BaseSize = new Vector3(0.06f, 0.03f, 0.06f);

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1f, 0f, 0f, 0.3f);
        Vector3 aSize = new Vector3(BaseSize.x * SizeX, BaseSize.y, BaseSize.z * SizeZ);
        Gizmos.DrawCube(transform.position, aSize);
    }
}

