#pragma strict

var DayMenuLabel : Transform;
var DayMenuMainMenu : Transform;
var DayMenuNightVisit: Transform;
var DayMenuResume : Transform;

function Start () {

}

function OnMouseDown () {
		DayMenuLabel.GetComponent.<Animation>().Play("DayMenuPopIn");
		DayMenuMainMenu.GetComponent.<Animation>().Play("DayMenuPopIn");
		DayMenuNightVisit.GetComponent.<Animation>().Play("DayMenuPopIn");
		DayMenuResume.GetComponent.<Animation>().Play("DayMenuPopIn");


}


