using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //esto le dice a esta classe que lo que usualmente no s epuede visualizar en Unity, si se pueda y se compile en tiempo real en Unity
public class AudioItemClass
{
    public string key;
    public AudioClip audio;
}

public class SoundManager : MonoBehaviour
{
    private static SoundManager _instance;

    public static SoundManager instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = GameObject.FindObjectOfType<SoundManager>();

            }

            return _instance;

        }

    }

    //propiedades
    public AudioSource bgmAudioSource;
    public AudioSource sfxAudioSource;
    [Header("Lista de musica de fondo")]
    public List<AudioItemClass> bgmAudioItems;
    [Header("Lista de efectos de sonido")]
    public List<AudioItemClass> sfxAudioItems;


    //Metodo para darle play a un audio
    public void PlayBGMAudioClip(string _key)
    {
        //Que se reproducza el audio que se solicite
        AudioClip searchedAudio = SearchBGMAudioClip(_key);
        if (searchedAudio != null)
        {
            bgmAudioSource.clip = searchedAudio;
            bgmAudioSource.Play();
        }
        else
        {
            Debug.LogWarning("Audio Clip no encontrado");
        }
        //AudioClip Audio = SearchAudioClip(_key);     //el audio con la lista de la llave enviada
        
    }

    public void PlaySFXAudioClip(string _key)
    {
        //Que se reproducza el audio que se solicite
        AudioClip searchedAudio = SearchSFXAudioClip(_key);
        if (searchedAudio != null)
        {
            sfxAudioSource.clip = searchedAudio;
            
                sfxAudioSource.Play();
        }
        else
        {
            Debug.LogWarning("Audio Clip no encontrado");
        }
        //AudioClip Audio = SearchAudioClip(_key);     //el audio con la lista de la llave enviada

    }

    //metodo para modificar el volumen
    public void SetBGMVolume(float _value)
    {
        if (_value <= 0)
            _value = 0;
        if (_value >= 1)
            _value = 1;
        bgmAudioSource.volume = _value;
    }

    public void SetSFXVolume(float _value)
    {
        if (_value <= 0)
            _value = 0;
        if (_value >= 1)
            _value = 1;
        sfxAudioSource.volume = _value;
    }
    //detener la musica

    public void StopBGMAudio()
    {
        if (bgmAudioSource.isPlaying)
            bgmAudioSource.Stop();
    }

    public void StopSFXAudio()
    {
        if (sfxAudioSource.isPlaying)
            sfxAudioSource.Stop();
    }

    private AudioClip SearchBGMAudioClip(string _key)
    {
        foreach (AudioItemClass audioItem in bgmAudioItems)
        {
            if (audioItem.key == _key)
                return audioItem.audio;
        }


        return null;
    }

    private AudioClip SearchSFXAudioClip(string _key)
    {
        foreach (AudioItemClass audioItem in sfxAudioItems)
        {
            if (audioItem.key == _key)
                return audioItem.audio;
        }


        return null;
    }


}
