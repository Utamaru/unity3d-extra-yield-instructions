using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using CustomYieldInstructions;
using Examples;
using UnityEngine;

public class ExampleWaitAny : ExampleBase
{
    private void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }
    private IEnumerator ExampleCoroutine()
    {        
        yield return StartCoroutine(WaitAnyExampleOne());
        Debug.Log(string.Empty);
        yield return StartCoroutine(WaitAnyExampleTwo());
    }
    
    private IEnumerator WaitAnyExampleOne()
    {
        Debug.Log("WaitAny example #1 started");
        yield return new WaitAny(this, WaitOne(), WaitTwo(), WaitThree());
        Debug.Log("WaitAny example #1 ended");
        yield return new WaitForSeconds(3.0f);
    }
    
    private IEnumerator WaitAnyExampleTwo()
    {
        Debug.Log("WaitAny example #2 started");
        yield return this.WaitAny(WaitOne(), WaitTwo(), WaitThree());
        Debug.Log("WaitAny example #2 ended");
        yield return new WaitForSeconds(3.0f);
    }

}

