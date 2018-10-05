using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCoche : MonoBehaviour {

    public GameObject cocheGo;

    public float anguloGiro;
    public float velocidad;

	// Use this for initialization
	void Start () {
        cocheGo = GameObject.FindObjectOfType<Coche>().gameObject;

	}
	
	// Update is called once per frame
	void Update () {
        float giroZ = 0;
        transform.Translate(Vector2.right * Input.GetAxis("Horizontal") * velocidad * Time.deltaTime);
        giroZ = Input.GetAxis("Horizontal") * anguloGiro;
        cocheGo.transform.rotation = Quaternion.Euler(0, 0, -giroZ);
		
	}
}
