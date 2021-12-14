using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JuegocAmigos : MonoBehaviour
{
    public GameObject Escoger_plantillas;
    public GameObject CrearMemorama;
    public GameObject SalaEstudioAmigos_general;
    // Start is called before the first frame update
    void Start()
    {
        Escoger_plantillas.SetActive(false);
        CrearMemorama.SetActive(false);
    }

    public void EscogerPlantillaPanel()
    {
        Escoger_plantillas.SetActive(true);
        SalaEstudioAmigos_general.SetActive(false);
    }

    public void CrearMemoramaPanel()
    {
        Escoger_plantillas.SetActive(false);
        CrearMemorama.SetActive(true);
    }

    public void ChangeSceneStartGame()
    {
        SceneManager.LoadScene("MemoramaExample");
    }

    //Botones para regresar

    public void ButtonRegresar_Inicio()
    {
        SceneManager.LoadScene("PantallaInicio");
    }

    public void ButtonRegresar_General()
    {
        SalaEstudioAmigos_general.SetActive(true);
        Escoger_plantillas.SetActive(false);
    }

    public void ButtonRegresar_EscogerPlantilla()
    {
        Escoger_plantillas.SetActive(true);
        CrearMemorama.SetActive(false);
    }
}
