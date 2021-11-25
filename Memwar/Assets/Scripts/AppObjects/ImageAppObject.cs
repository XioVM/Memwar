using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAppObject : AppObject
{
    // Start is called before the first frame update
    void Start()
    {
        AddEventListener<TestEvent>(TestEventListener);
    }

    // Update is called once per frame
    private void TestEventListener(TestEvent eventData)
    {
        //GetComponentInChildren<Text>().text = eventData.GetText();
        GetComponent<Image>().color = Color.red;
    }
}
