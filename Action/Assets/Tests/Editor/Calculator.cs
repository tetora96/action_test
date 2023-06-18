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
    [TestCase(1)]
    public void 失敗テスト(int a){
        Assert.AreEqual(5, a);
    }

    public int Add(int a, int b){
        return a + b;
    }
}
