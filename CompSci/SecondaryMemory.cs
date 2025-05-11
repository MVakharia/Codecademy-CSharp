using UnityEngine;

public class SecondaryMemory : MonoBehaviour
{
    /// <summary>
    /// Permanent data storage. 
    /// </summary>
    sbyte[] storageDrive = new sbyte[] { 1, 1, 1, 1, 1, 1, 1, 1 };

    sbyte[] StorageDrive => storageDrive;

}
