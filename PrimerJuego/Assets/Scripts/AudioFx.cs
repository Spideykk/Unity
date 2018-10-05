using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFx : MonoBehaviour {

    public AudioClip[] ArrayClips;
    public AudioSource AudioControlador;

	// Use this for initialization
	void Start () {
        AudioControlador = GetComponent<AudioSource>();
	}
	
    public void FxSonidoChoque()
    {
        AudioControlador.clip = ArrayClips[0];
        AudioControlador.Play();
    }

    public void FxSonidoBasico()
    {
        AudioControlador.clip = ArrayClips[1];
        AudioControlador.Play();
    }
    // Update is called once per frame

}
