using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework;
using System.Runtime.InteropServices.WindowsRuntime;

public enum DataStructureType
{
    Array, List, Dictionary, Object
}

/// <summary>
/// Transforms data into something that a program can actually use. 
/// 
/// Maintains data.
/// 
/// Utilizes data.
/// 
/// Iterates through data. 
/// </summary>
public class Algorithm
{

}

/// <summary>
/// A method of storing and retrieving data.
/// 
/// Lists, arrays, dictionaries, and objects are examples of data structures. 

/// </summary>
public class DataStructure : MonoBehaviour
{
    /// <summary>
    /// An array, a type of data structure.
    /// </summary>
    public int[] dataStructure_Array;

    /// <summary>
    /// A list, a type of data structure.
    /// </summary>
    public List<int> dataStructure_List;

    /// <summary>
    /// The type of data structure that is right for you.
    /// 
    /// What is the intended purpose of the data?
    /// </summary>
    public DataStructureType structureType;

    /// <summary>
    /// Different data structures accomplish tasks at different speeds.
    /// 
    /// Runtime is the speed at which a data structure accomplishes a task. 
    /// </summary>
    public int runtime => 0;


    /// <summary>
    /// Concerned with how the data is received.
    /// 
    /// What kind of information can be included? 
    /// 
    /// Will the new data be added to the beginning, end, or somewhere in the middle of the existing data? 
    /// 
    /// Does an existing point of data need to be updated or destroyed?
    /// </summary>
    public void Information_Input ()
    {

    }

    /// <summary>
    /// The way that data is manipulated in the data structure. 
    /// 
    /// Can occur concurrently or as a result of other processes that data structures handle. 
    /// 
    /// How does existing data that has been stored need to change to accommodate new, updated, or removed data? 
    /// </summary>
    public void Information_Process ()
    {

    }


    /// <summary>
    /// How the data is organized within the structure.
    /// 
    /// Which relationships need to be maintained between pieces of data?
    /// 
    /// How much memory must the system reserve (allocate) to accommodate the data?
    /// </summary>
    public void Information_Maintain()
    {

    }

    /// <summary>
    /// Finds and returns the data that is stored in the structure.
    /// 
    /// How can we access that information again? 
    /// 
    /// What steps does the data structure need to take to get the information back to us?
    /// </summary>
    public void Information_Retrieve ()
    {

    }

    /// <summary>
    /// Can only be called if the data structure is a stack, array, 
    /// or some other data structure that uses static memory allocation. 
    /// 
    /// Data structures that use this manage memory for you
    /// and assume a fixed amount of memory upon instantiation 
    /// with a cap on how much data may be added. 
    /// </summary>
    public void AllocateMemory_Static ()
    {

    }

    /// <summary>
    /// Can only be called if the data structure is a heap, linked list, 
    /// or some other data structure that utilizes dynamic memory allocation.
    /// 
    /// Data structures that use this allow you to allocate and reallocate memory 
    /// within the life of the program. 
    /// </summary>
    public void AllocateMemory_Dynamic ()
    {

    }

}
