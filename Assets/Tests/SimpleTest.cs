﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.TestTools;

public class SimpleTest
{
    [Test]
    public void NUnityTest()
    {
        Assert.IsTrue(false);
    }

    [UnityTest]
    public IEnumerator UnityTest()
    {
        yield return new WaitForFixedUpdate();

        Assert.IsTrue(false, "UnityTestFailed");
    }
}
