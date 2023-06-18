using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class Calculator
{

    [TestCase(1,2)]
    public void テスト(int a, int b){
        Add(a,b);

    }

    public int Add(int a, int b){
        return a + b;
    }
}
