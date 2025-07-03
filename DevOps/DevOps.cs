using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Concept
{
    public string practiceName;
    public string practiceDescription;

    public Concept (string name, string description)
    {
        practiceName = name;
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

    private Concept sysLevelThink = new Concept(
        "Systems-level thinking",
        "Every member of every team thinks about every part of the development process."
        );

    private Concept feedbackLoops = new Concept(
        "",
        "");

    private Concept automation = new Concept(
        "Automation", 
        "Making manual processes occur automatically instead."
        );

    private Concept continuousIntegration = new Concept(
        "Continuous Integration",
        "The regular merging of contributor code into a central repo."
        );

    private Concept contDeployAndDeliver = new Concept(
        "Continuous Deployment And Delivery",
        "Automatically preparing code changes for release"
        );

    private Concept infrastructureAsCode = new Concept(
        "Infrastructure As Code",
        "Representing aspects of infrastructure within source code files."
        );

    private Concept microservices = new Concept(
        "Microservices",
        "Dividing up a business application into many small independent services."
        );

    private Concept Monitoring = new Concept(
        "Monitoring",
        "Gathering information about the state of the system during runtime"
        );



}
