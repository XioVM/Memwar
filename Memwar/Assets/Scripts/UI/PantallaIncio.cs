using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PantallaIncio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AreaJuegoSolitario()
    {
        SceneManager.LoadScene("JuegoSolitario");
    }

    public void AreaJuegoAmigos()
    {
        SceneManager.LoadScene("");
    }

    public void AreaJuegoRamdom()
    {
        SceneManager.LoadScene("");
    }
}
