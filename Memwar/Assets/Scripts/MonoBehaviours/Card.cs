using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public int card_id;
    public Color revealedColor; //cartas de gris a color

    private Color basecolor; //cartas de color a gris
    private Image childImage;

    private void Start()
    {
        childImage = transform.GetChild(0).GetComponent<Image>();
        basecolor = childImage.color;
    }



    public void CardOnClick()
    {
        //que se voltee
        //mandar id a memorama manager
        MemoramaManager.instance.CardReceived(this); //este es el codigo que esta ligado con los instances privados y publicos del otro codigo
        GetComponent<Animator>().SetTrigger("Clicked");
        SoundManager.instance.PlaySFXAudioClip("Click");

    }

    public void SetCardInteraction(bool value)
    {
        GetComponent<Button>().interactable = value; //agarrar otro componente del mismo objeto
    }

    public void SetCardColor()
    {
        bool value = GetComponent<Button>().interactable;
        childImage.color = value ? basecolor : revealedColor; //el ? es un if resumido. serìa como escribir un if y luego un else
        //objeto que se quiere cambiar = booleano verdadero o falso ? se pone lo que se quiere cambiar si es verdadero y lo que serà si es falso. de ley tiene que haber un else 
        
    }

}