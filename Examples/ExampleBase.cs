using System.Collections;
using UnityEngine;

namespace Examples
{
    public class ExampleBase : MonoBehaviour
    {
        protected IEnumerator WaitOne()
        {
            Debug.Log("WaitOne started");
            yield return new WaitForSeconds(1.0f);
            Debug.Log("WaitOne ended");
        }

        protected IEnumerator WaitTwo()
        {
            Debug.Log("WaitTwo started");
            yield return new WaitForSeconds(2.0f);
            Debug.Log("WaitTwo ended");
        }

        protected IEnumerator WaitThree()
        {
            Debug.Log("WaitThree started");
            yield return new WaitForSeconds(3.0f);
            Debug.Log("WaitThree ended");
        }
    }
}