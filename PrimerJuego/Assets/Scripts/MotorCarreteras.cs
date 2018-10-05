using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorCarreteras : MonoBehaviour {

	public GameObject contenedorCallesGo;
	public GameObject[] arrayCalles;
	public GameObject CalleAnterior;
	public  GameObject CalleSiguiente;
	public GameObject mCamGo;

	public float velocidadJuego;
	public bool inicioJuego;
	public bool juegoTerminado;
	public float tamañoCalle = 0;
	int contadorCalles = 0;
	int selectorCalles;
	public Vector3 medidaPantalla;
	public bool salioPantalla;
	public Camera mCampComp;


	

	// Use this for initialization
	void Start () {
		
		IniciJuego();
	}

	void IniciJuego(){
		contenedorCallesGo = GameObject.Find("ContenedorCarreteras");
		VelocidadMotorCarreteras();
		
		mCamGo = GameObject.Find("MainCamera");
		mCampComp = mCamGo.GetComponent<Camera>();
		BuscoCalles();
		MedirPantalla();
	}
	
	void VelocidadMotorCarreteras(){
		velocidadJuego = 10;
	}

	void BuscoCalles(){
		arrayCalles = GameObject.FindGameObjectsWithTag("Calle");
		for (int i = 0; i < arrayCalles.Length; i++){
			arrayCalles[i].gameObject.transform.parent = contenedorCallesGo.transform;
			arrayCalles[i].gameObject.SetActive(false);
			arrayCalles[i].gameObject.name = "CalleOFF_"+i;
		}
		CrearCalle();
	}
	// Update is called once per frame
	void CrearCalle(){
		contadorCalles ++;
		selectorCalles = Random.Range(0,arrayCalles.Length);
		GameObject Calle = Instantiate(arrayCalles[selectorCalles]);
		Calle.SetActive(true);
		Calle.name = "Calle" + contadorCalles;
		Calle.transform.parent = gameObject.transform;
		PosicionoCalle();
	}

	void PosicionoCalle(){
		CalleAnterior = GameObject.Find("Calle"+(contadorCalles-1));
		CalleSiguiente = GameObject.Find("Calle"+(contadorCalles));
		MidoCalle();
		CalleSiguiente.transform.position = new Vector3(CalleAnterior.transform.position.x,CalleAnterior.transform.position.y + tamañoCalle,0);
		salioPantalla = false;
	}

	void MidoCalle(){
		for (int i= 0; i< CalleAnterior.transform.childCount; i++){
			if (CalleAnterior.transform.GetChild(i).gameObject.GetComponent<CalleRecta>() != null){
				float tamañoPieza = CalleAnterior.transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>().bounds.size.y-3.2f;
				tamañoCalle = tamañoCalle + tamañoPieza;
			}
		}
	}

	void MedirPantalla(){

		medidaPantalla = new Vector3(0,mCampComp.ScreenToWorldPoint(new Vector3(0,0,0)).y -10.6f,0);
	}

	void DestruyoCalle(){
		Destroy(CalleAnterior);
		tamañoCalle = 0;
		CalleAnterior = null;
		CrearCalle();
	}
	void Update () {

		if (inicioJuego == true && juegoTerminado == false){
			transform.Translate(Vector3.down * velocidadJuego * Time.deltaTime);
		}
		if (CalleAnterior.transform.position.y + tamañoCalle < medidaPantalla.y && salioPantalla == false){
			salioPantalla = true;
			DestruyoCalle();
		}
	}
}
