#pragma strict

var NightMenuLabel : Transform;
var NightMenuMainMenu : Transform;
var NightMenuDayVisit: Transform;
var NightMenuResume : Transform;

function Start () {

}

function OnMouseDown () {
		NightMenuLabel.GetComponent.<Animation>().Play("NightMenuPopIn");
		NightMenuMainMenu.GetComponent.<Animation>().Play("NightMenuPopIn");
		NightMenuDayVisit.GetComponent.<Animation>().Play("NightMenuPopIn");
		NightMenuResume.GetComponent.<Animation>().Play("NightMenuPopIn");


}

