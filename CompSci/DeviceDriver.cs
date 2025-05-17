using JetBrains.Annotations;
using UnityEngine;

/// <summary>
/// This software is designed for one specific device.
/// 
/// Used to support communication between the CPU and a specific IO device. 
/// </summary>
public class DeviceDriver : InputOutputSoftware
{
    private string deviceID;

    private InterruptHandler interruptHandler;


}
