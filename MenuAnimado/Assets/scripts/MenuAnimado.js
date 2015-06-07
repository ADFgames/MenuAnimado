#pragma strict

var ancho = 200;
var alto = 0;
var velocidad : float = 0.010;
var duracion : float;
var SKIN : GUISkin; 
var cerrar:  boolean = false;
var abrir : boolean = false;
var cambia : boolean = false;
//var gerenciador : Gerenciador;

function Start () {
	//gerenciador = FindObjectOfType(typeof(Gerenciador)) as Gerenciador;
}

function Update () {

    if (abrir){
	
        duracion =  duracion + Time.deltaTime/2  ;
        alto = Mathf.Lerp(20,Screen.height / 2 + 100, duracion);
        ancho = Mathf.Lerp(20,200 + 100, duracion);
		
		
	
    }if (cerrar){
		
		
        duracion =  duracion + Time.deltaTime/2  ;
        alto = Mathf.Lerp(Screen.height / 2 + 100,20, duracion);
        ancho = Mathf.Lerp(200 + 100,20, duracion);
	
    }if (cambia){
		
        duracion = 0;
        cambia = false;
	
    }

}function OnGUI(){

	
	
    GUI.skin = SKIN;
	
    GUI.Window(0,Rect(30,30,ancho, alto),Menu,"MENU");
	
    if(GUI.Button(Rect(Screen.width - 200, 50,50,30),"UP")){
	
        cambia = true;
        abrir = true;
        cerrar = false;
		
    }if(GUI.Button(Rect(Screen.width - 200, 150,50,30),"DOWN")){
	
        cambia = true;
        abrir = false;
        cerrar = true;
    }

}function Menu (){

	if(GUI.Button(Rect(75,50,150,30),"Start"))
	{
	//gerenciador.ProximoLevel(gerenciador.proximoLevel);
	}
	
	if(GUI.Button(Rect(75,100,150,30),"Creditos"))
	{
	
	}
	
	if(GUI.Button(Rect(75,150,150,30),"Sair"))
	{
	
	}
// Graphics.DrawTexture(new Rect(10, 10, 100, 100), aTexture);
	//Graphics.DrawTexture(new Rect(75,200,150,30),"LogoADF");
	//GUI.DrawTexture(new Rect(5,200,150,30), "LogoADF",true);

}