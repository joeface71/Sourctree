using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public delegate void TestDelegate();
    public delegate bool TestBoolDelegate(int i);

    private TestDelegate testDelegateFunction;
    private TestBoolDelegate testBoolDelegate;

    private void Start()
    {
        testBoolDelegate = MyTestBoolDelegateFunction;

        Debug.Log(testBoolDelegate(6));
    }

    private void MyTestDelegateFunction()
    {
        Debug.Log("MyTestDelegateFunction");
    }

    private void MySecondDelegateFunction()
    {
        Debug.Log("MySecondDelegateFunction");
    }

    private bool MyTestBoolDelegateFunction(int i)
    {
        if (i > 5)
            return true;
        return false;
    }

}
