using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JuegoSolitario : MonoBehaviour
{
    public GameObject Escoger_plantillas;
    public GameObject CrearMemorama;
    public GameObject SalaEstudio_general;

    // Start is called before the first frame update
    void Start()
    {
        Escoger_plantillas.SetActive(false);
        CrearMemorama.SetActive(false);
    }

    public void EscogerPlantillaPanel()
    {
        Escoger_plantillas.SetActive(true);
        SalaEstudio_general.SetActive(false);
    }

    public void CrearMemoramaPanel()
    {
        Escoger_plantillas.SetActive(false);
        CrearMemorama.SetActive(true);
    }

    public void ChangeSceneStarGame()
    {
        SceneManager.LoadScene("MemoramaExample");
    }
}
