# Extra yield instructions for Unity3D
 Additional custom yield instructions with various purposes for Unity3D's coroutines 
 
 ## WaitAny
 Suspends the coroutine execution until all coroutines passed to the method complete their execution.
 
 Usage example:
 ```
 yield return new WaitAll(this, WaitOne(), WaitTwo(), WaitThree());
 ```
 or usage example with extension method:
 ```
 yield return this.WaitAll(WaitOne(), WaitTwo(), WaitThree());
 ```
 where `this` is of type of `MonoBehaviour`
 
 ## WaitAll
 Suspends the coroutine execution until any single of the coroutines passed to the method complete their execution.
 
 Usage example:
 ```
 yield return new WaitAny(this, WaitOne(), WaitTwo(), WaitThree());
 ```
 or usage example with extension method:
 ```
 yield return this.WaitAny(WaitOne(), WaitTwo(), WaitThree());
 ```
 where `this` is of type of `MonoBehaviour`
