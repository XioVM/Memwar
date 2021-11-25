using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogInUI : MonoBehaviour
{

    private string testEmail = "correo@gmail.com";
    private string testPassword = "123";

    public InputField emailInputField;
    public InputField passwordInputField;
    public GameObject errorPanelObject;


    // Start is called before the first frame update
    void Start()
    {

        //se cambio el nombre de los tring testEmail y test Password
        //despues del debug se pone el cambio de escenas el de inicio de sesiòn, antes del returnn

    }

    public void LogInButtonOnclick()
    {
        if (testEmail == emailInputField.text)
        {
            if (testPassword == passwordInputField.text)
            {
                Debug.Log("Inicio de sesion exitosa");
                SceneManager.LoadScene("MainScene");

                return;

            }
        }

        Debug.Log("inicio de sesion fallida");
        errorPanelObject.SetActive(true);

    }

    public void LogOutOnClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

