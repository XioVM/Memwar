using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonIngresar : MonoBehaviour
{
    public void BotonIngresarOnClick()
    {
        SceneManager.LoadScene("TengoCuenta");
    }

    //agregue el script en el boton, ese script lo arrastre a buttononclick, agregue el registroonclick. File, Build Settings y agregar las escenas donde estas y donde quieres ir. 
}
