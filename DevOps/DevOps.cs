using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Practice
{
    public string practiceDescription;

    public Practice (string description)
    {
        practiceDescription = description;
    }
}

/// <summary>
/// A culture supported by practices and tools. 
/// 
/// Enables Development teams and Operations teams to work together. 
/// 
/// The resulting colllaboration between the teams aims to achieve faster and higher-quality productions.
/// 
/// Seeks to integrate Development team and Operations team 
/// by having them work together, resulting in 'resultsOfUsingDevOps'.
/// 
/// The culture is the most critical factor to the success of DevOps. 
/// 
/// Collaboration cannot occur only from applying the practices and tools of DevOps. 
/// 
/// Collaboration requires a culture in which it can thrive. 
/// </summary>
public class DevOps : MonoBehaviour
{
    private DevelopmentTeam devTeam;

    private OperationsTeam opsTeam;

    private readonly string[] resultsOfUsingDevOps = new string[] {
     "Consistent development",
     "Consistent testing",
     "Consistent production environments",
     "Fewer hand-offs",
     "Shared information",
     "Shared context",
     "Management of infrastructure with development tools"
    };

    private readonly string[] pillarsOfDevOps = new string[]
    {
        "Thinking about the whole production system, rather than a single department or part.",
        "Feedback loops, allowing each part of the process to receive information and improve.",
        "A culture of continuous experimentation and learning."
    };

    private Practice automation = new Practice("Making manual processes occur automatically instead.");




}
