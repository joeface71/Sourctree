﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public delegate void TestDelegate();
    public delegate bool TestBoolDelegate(int i);

    public Action<int> testAction;

    private TestDelegate testDelegateFunction;
    private TestBoolDelegate testBoolDelegate;



    private void Start()
    {
        testBoolDelegate = MyTestBoolDelegateFunction;
        testAction = MyTestAction;

        Debug.Log(testBoolDelegate(6));
        testAction(5);

    }

    private void MyTestAction(int i)
    {
        Debug.Log(i);
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
