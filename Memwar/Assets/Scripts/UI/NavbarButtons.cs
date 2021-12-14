using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavbarButtons : MonoBehaviour
{
    public GameObject MenuPanel;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OpenMenu()
    {
        MenuPanel.SetActive(true);
    }

    public void CloseMenu()
    {
        MenuPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
