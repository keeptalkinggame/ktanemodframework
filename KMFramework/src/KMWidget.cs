using UnityEngine;

public class KMWidget : MonoBehaviour
{
    public int SizeX;
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

