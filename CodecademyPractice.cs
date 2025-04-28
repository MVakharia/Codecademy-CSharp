using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class CodecademyPractice : MonoBehaviour
{
    /*
     
    I'd like for this project to eventually become an Android app with a minimalist art style.

    The intention is for the app to explain programming concepts 
    and computer science in a way that's simple and easy to understand.
     
     */

    readonly List<string> cSharpConcepts = new List<string>
    {
        "The 'char' data type",

        "The difference between statically typed and dynamically typed languages",

        "The difference between weakly and strongly typed languages"
    };

    void Start()
    {

    }

    

    void VarKeywordShort ()
    {
        //The 'var' keyword

        //Use 'var' to define an implicitly-typed variable. 

        var shortSentences = from c in cSharpConcepts where c.Length < 20 select c;

        foreach (var sentence in shortSentences)
        {
            Debug.Log(sentence);
        }
    }

    void varKeywordLong ()
    {
        var longSentences = cSharpConcepts.Where(c => c.Length > 20);

        Debug.Log(longSentences.Count());
    }

    void QueryListWithoutLINQ ()
    {
        //Querying a list without LINQ (the slower way with more lines of code)
        List<string> capitalisedConcepts = new List<string>();

        foreach (string c in cSharpConcepts)
        {
            if (c.Length > 20)
            {
                string formatted = c.ToUpper();

                capitalisedConcepts.Add(formatted);
            }
        }

        foreach (var c in capitalisedConcepts)
        {
            Debug.Log(c);
        }
    }

    /// <summary>
    /// Creates a new list based on cSharpConcepts that 
    /// omits all elements with fewer than 20 characters and capitalises the rest. 
    /// </summary>
    void QueryListWithLINQ_QuerySyntax()
    {
        //Querying a list with LINQ and query syntax (the quicker way, with fewer lines of code)
        
        var capitalisedConcepts2 = from c in cSharpConcepts where c.Length > 20 select c.ToUpper();

        foreach (var c in capitalisedConcepts2)
        {
            Debug.Log(c);
        }
    }


    void QueryListWithLINQ_MethodSyntax()
    {
        //Querying a list with LINQ and method syntax (more readable for users unfamiliar with LINQ)

        var capitalisedConcepts3 = cSharpConcepts.Where(c => c.Length > 20).Select(c => c.ToUpper());

        foreach (var c in capitalisedConcepts3)
        {
            Debug.Log(c);
        }
    }

    /// <summary>
    /// Creates a new list based on cSharpConcepts with only the elements that include the word 'language'.
    /// 
    /// Then it replaces all of those elements with the word 'hello'. 
    /// </summary>
    void QueryContainsLanguages_MethodSyntax_NonsenseSelect()
    {
        var hasLanguages = cSharpConcepts.Where(c => c.Contains("languages")).Select(c => "hello");

        foreach(var c in hasLanguages)
        {
            Debug.Log(c);
        }
    }

    /// <summary>
    /// Creates a new list based on cSharpConcepts with only the elements that include the word 'language'.
    /// 
    /// This version uses the 'Select()' method, 
    /// but since the method isn't making a change to an element, it can be omitted.
    /// </summary>
    void QueryContainsLanguages_MethodSyntax_Select()
    {
        var hasLanguages = cSharpConcepts.Where(c => c.Contains("languages")).Select(c => c);

        foreach (var c in hasLanguages)
        {
            Debug.Log(c);
        }
    }

    void QueryContainsLanguages_MethodSyntax_NoSelect ()
    {

    }

    void QueryContainsLanguages_QuerySyntax_Select()
    {
        var hasLanguages = from c in cSharpConcepts where c.Contains("Languages") select c;
    }

    void QueryReplacesWord ()
    {
    }
}
