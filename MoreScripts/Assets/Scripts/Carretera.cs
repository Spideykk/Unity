using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carretera : MonoBehaviour {

	Coche miCoche;
	// Use this for initialization
	void Start () {

		CrearCoche();
		
	}
	
	void CrearCoche(){
		miCoche = new Coche();
		miCoche.cantidadPuertas = 4;
		miCoche.ruedas = 4;
		miCoche.EncenderMotor();	
	}
	// Update is called once per frame
	void Update () {
		
	}
}
