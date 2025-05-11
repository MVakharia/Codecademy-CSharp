using UnityEngine;

enum ProcessState
{
    New, Ready, Running, Blocked, Finished
}

public class SystemResource
{

}

public class Permission
{

}

/// <summary>
/// The program counter for the address of the instruction currently being executed.
/// </summary>
public class ProgramCounter
{

}

enum ProcessPriority
{
    Low, Medium, High
}

/// <summary>
/// The address of other registers within the CPU holding intermediate values
/// </summary>
public class RegisterAddress
{

}

/// <summary>
/// Information required for memory management. 
/// </summary>
public class PageTable
{

}

/// <summary>
/// Information required for memory management. 
/// </summary>
public class SegmentTable
{

}

public class ControlBlock
{
    string uniqueProcessID;

    /// <summary>
    /// The ID of any parent processes that launched this process. 
    /// </summary>
    string[] parentProcessID;

    ProcessState state;

    /// <summary>
    /// How long the process has been running and any time limits the process may have
    /// </summary>
    float processRunningTime;

    SystemResource[] allowedSystemResources;

    Permission[] otherPermissions;

    ProcessPriority priority;

    ProgramCounter programCounter;

    RegisterAddress[] registerAddresses;

    PageTable[] pageTables;

    SegmentTable[] segmentTables;
}

/// <summary>
/// An abstract, dynamic data structure that represents all of the necessary 
/// operating system information to run a program. 
/// </summary>
public class Process : MonoBehaviour
{
    private ProcessState state;

    private ProcessState savedState;

    /// <summary>
    /// The process contains at least one thread to be able to execute.
    /// 
    /// More threads can be created if the CPU will allow it.
    /// </summary>
    private Thread[] threads;

    /// <summary>
    /// Run this whenever this process needs to wait for a contested, limited, or slow resource.
    /// 
    /// This could be a waiting period for a network request or access to a specific file. 
    /// </summary>
    public void Block()
    {
        savedState = state;

        state = ProcessState.Blocked;
    }

    public void Unblock() => state = savedState;

    private void Update()
    {
        switch(state)
        {
            case ProcessState.New: Debug.Log("This program has been started. " +
                "Program currently waiting to be added into memory in order to become a full process."); break;
            case ProcessState.Ready: Debug.Log("Process fully initialized, loaded into memory, " +
                "and waiting to be picked up by the processor."); break;
            case ProcessState.Running:
                Debug.Log("Process currently being executed by the processor."); break;
            case ProcessState.Blocked:
                Debug.Log("Process requires a contested resource that it must wait for. Please wait..."); break;
            case ProcessState.Finished:
                Debug.Log("Process complete."); break;
        }
    }
}
