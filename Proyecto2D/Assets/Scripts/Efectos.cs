using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efectos : MonoBehaviour {

	public void playEffect()
    {
        GetComponent<AudioSource>().Play();
    }
}
