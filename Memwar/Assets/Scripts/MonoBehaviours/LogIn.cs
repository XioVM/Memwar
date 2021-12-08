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
    public InputField ContrasenaInputField;
    public InputField UsuarioInputField;



    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void LoginButtonOnClick()
    {
        if (testemail == UsuarioInputField.text)
        {
            if(password == ContrasenaInputField.text)
            {
                Debug.Log("Inicio de sesión exitosa");
                SceneManager.LoadScene("Registro");
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

    public void IntentaDeNuevoOnClick()
    {
        SceneManager.LoadScene("TengoCuenta");
    }
}
