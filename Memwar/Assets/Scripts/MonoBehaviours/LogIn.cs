using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogIn : MonoBehaviour
{
    private string testemail = "memwar@gmail.com";
    private string password = "123";

    [Header("Mensaje de Error")]
    public GameObject WarningMessageObject;

    [Header("Textos de Entrada")]
    public InputField PasswordInputField;
    public InputField EmailInputField;



    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void LoginButtonOnClick()
    {
        if (testemail == EmailInputField.text)
        {
            if(password == PasswordInputField.text)
            {
                Debug.Log("Inicio de sesión exitosa");
                SceneManager.LoadScene("PantallaInicio");
                return;
            }
        }

        WarningMessageObject.SetActive(true);
        Debug.Log("Inicio de sesión Fallida");




    }

       public void LogOutOnClick()
    {
        SceneManager.LoadScene("NoAccess");
    }
}
