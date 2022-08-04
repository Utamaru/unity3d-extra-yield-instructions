using System.Collections;
using CustomYieldInstructions;
using Examples;
using UnityEngine;

public class ExampleWaitAll : ExampleBase
{
    private void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    private IEnumerator ExampleCoroutine()
    {
        yield return StartCoroutine(WaitAllExampleOne());
        Debug.Log(string.Empty);
        yield return StartCoroutine(WaitAllExampleTwo());
    }

    private IEnumerator WaitAllExampleOne()
    {
        Debug.Log("WaitAll example #1 started");
        yield return new WaitAll(this, WaitOne(), WaitTwo(), WaitThree());
        Debug.Log("WaitAll example #2 ended");
    }
    
    private IEnumerator WaitAllExampleTwo()
    {
        Debug.Log("WaitAll example #2 started");
        yield return this.WaitAll(WaitOne(), WaitTwo(), WaitThree());
        Debug.Log("WaitAll example #2 started");
    }
}

