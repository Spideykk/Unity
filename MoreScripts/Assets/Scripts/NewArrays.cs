using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewArrays : MonoBehaviour {
	string[] letras  = new string[5]{"a","b","c","d","e"};
	public int[] numeros;
	public float[] flotantes = new float[6]{1.1f,2.2f,0,0,0,0};
	public string[] animales ={"perro","gato","raton"};
	int i = 0;
	public int switches = 1;
	Brujula miBrujula = Brujula.Este;
	// Use this for initialization
	void Start () {

		Nombre();
		Debug.Log(miBrujula);
		foreach (string animal in animales){
			Debug.Log(animal);
		}
		do{
			Debug.Log(i+6);
			i++;
		}while(i<5);

		switch (switches){
			case 0:
				Debug.Log(switches);
				break;
			case 1:
				Debug.Log(switches);
				break;
			default:
				Debug.Log("Error");
				break;
		}
		
		
	}

	// Funcion de prueba

	void Nombre(){
		Debug.Log("Probando");
	}
	
	// Update is called once per frame
	public enum Brujula {Norte,Sur,Este,Oeste}
}
