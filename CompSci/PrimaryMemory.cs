using UnityEngine;

/// <summary>
/// Temporary data storage.
/// </summary>
public class PrimaryMemory : MonoBehaviour
{
    [SerializeField]
    private sbyte[] ram = new sbyte[] { 1, 1, 1, 1 };

    public sbyte[] RAM => ram;
}
