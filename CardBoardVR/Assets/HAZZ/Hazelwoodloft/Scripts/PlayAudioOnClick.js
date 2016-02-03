#pragma strict

var FX_DayMenu_3FX : AudioClip;


function Start () {

}

function OnMouseDown () {
		GetComponent.<AudioSource>().PlayOneShot(FX_DayMenu_3FX);
	


}