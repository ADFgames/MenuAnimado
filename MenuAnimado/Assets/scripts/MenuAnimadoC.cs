﻿using UnityEngine;
using System.Collections;

public class MenuAnimadoC : MonoBehaviour {

	private Gerenciador gerenciador;
	private GUISkin SKIN;
	private float ancho = 200f;
	private float alto = 0f;
	private float velocidad = 0.010f;
	private float duracion;
	private bool cerrar = false;
	private bool abrir = false;
	private bool cambia = false;

	// Use this for initialization
	void Start () {
		gerenciador = FindObjectOfType(typeof(Gerenciador)) as Gerenciador;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (abrir)
		{
			
			duracion =  duracion + Time.deltaTime/2  ;
			alto = Mathf.Lerp(20,Screen.height / 2 + 100, duracion);
			ancho = Mathf.Lerp(20,200 + 100, duracion);
			
			
			
		}
		if (cerrar)
		{
			
			
			duracion =  duracion + Time.deltaTime/2  ;
			alto = Mathf.Lerp(Screen.height / 2 + 100,20, duracion);
			ancho = Mathf.Lerp(200 + 100,20, duracion);
			
		}
		if (cambia)
		{
			
			duracion = 0;
			cambia = false;
			
		}

	}

	void OnGUI()
	{
		GUI.skin = SKIN;

		//GUI.Window(0,new Rect(30,30,ancho, alto),Menu,"MENU");
		GUI.Window(0,new Rect(30,30,ancho, alto),Menu,"MENU");

		if (GUI.Button (new Rect (Screen.width - 200, 50, 50, 30), "UP"))
			//GUI.Button (Rect (Screen.width - 200, 50, 50, 30), "", "");
		{
			
			cambia = true;
			abrir = true;
			cerrar = false;
			
		}

		if(GUI.Button(new Rect(Screen.width - 200, 150,50,30),"DOWN"))
		{
			
			cambia = true;
			abrir = false;
			cerrar = true;
		}

	}

	public void Menu(int menuscreen)
	{
		if(GUI.Button(new Rect(75,50,150,30),"Start"))
		{
			gerenciador.ProximoLevel(gerenciador.proximoLevel);
		}
		
		if(GUI.Button(new Rect(75,100,150,30),"Creditos"))
		{
			
		}
		
		if(GUI.Button(new Rect(75,150,150,30),"Sair"))
		{
			
		}
	}
}
