using UnityEngine;

/// <summary>
/// The type of thread.
/// 
/// Kernel threads are threads created in kernel space using kernel code and libraries through a system call.
/// 
/// The kernel is fully aware of these threads and can properly manage them.
/// 
/// User threads are threads created in user space using local code and function calls.
/// 
/// The kernel is not aware of these threads and cannot directly control them.
/// </summary>
public enum ThreadType
{
    Kernel, User
}

/// <summary>
/// The sequence of processor instructions that are actively being executed. 
/// 
/// Lives within a process and shares all of the common resources available to the process, 
/// 
/// for example, memory pages and active files. 
/// </summary>
public class Thread : MonoBehaviour
{

}
