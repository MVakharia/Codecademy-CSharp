using System;
using UnityEngine;

public class CentralProcessingUnit : MonoBehaviour
{
    PrimaryMemory primaryMemory;

    /// <summary>
    /// The process currently being executed. The CPU can normally only execute one process at a time. 
    /// </summary>
    Process currentProcess;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Press W to see the input sequence in action.");

        Debug.Log("Press O to open a program.");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Event received by input device (keyboard, key press).");

            Debug.Log("Converting event information to binary code.");

            Debug.Log("Conversion complete.");

            Debug.Log("Sending binary code to CPU.");

            CPU_Function("key press");
        }
        if(Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Event received by input device (keyboard, key press)");

            Debug.Log("Converting event information to binary code.");

            Debug.Log("Conversion complete.");

            Debug.Log("Sending binary code to CPU.");

            CPU_Function("key press to open program");
        }

    }

    /// <summary>
    /// The 'brain' of the computer.
    /// 
    /// Controls all different components between hardware and software.
    /// 
    /// Establishes communication between hardware and software. 
    /// 
    /// Performs all necessary operations for software to run on the computer. 
    /// </summary>
    void CPU_Function (string command)
    {
        Debug.Log("Deciphering binary code.");

        if (command == "key press")
        {
            
        }
        else if(command == "key press to open program")
        {
            Debug.Log($"Retrieving data from primary memory (${primaryMemory.RAM[0]}).");

            Debug.Log("Instructions located.");

            Debug.Log("Executing instructions.");
        }
    }

    /// <summary>
    /// Blocks the current process. The next process in the queue will automatically start. 
    /// </summary>
    /// <param name="interrupt"></param>
    /// <param name="prioritise"></param>
    void PreEmpt (Process interrupt, Process prioritise)
    {
        interrupt.Block();
    }
}