using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAppObject : AppObject
{
    public void ButtonOnClick()
    {
        InvokeEvent<TestEvent>(new TestEvent("que complicado es"));
    }
}
