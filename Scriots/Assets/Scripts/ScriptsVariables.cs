using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptsVariables : MonoBehaviour {


    public int numEntero;
    public float numFlotante = 1.1f;
    public string palabras = "Hola Mundo";
    public GameObject camera;
    public Transform transform;
    public int a= 4;
    public int b = 5;
    public bool isTrue;


    // Use this for initialization
    void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
        if (isTrue)
        {
            Debug.Log(a + b + "Suma");
        }
        else
        {
            Debug.Log(a - b + "Resta");
        }

    }
}
