#pragma strict

var DayMenuLabel : Transform;
var DayMenuMainMenu : Transform;
var DayMenuNightVisit: Transform;
var DayMenuResume : Transform;

function Start () {

}

function OnMouseDown () {
		DayMenuLabel.GetComponent.<Animation>().Play("DayMenuPopOut");
		DayMenuMainMenu.GetComponent.<Animation>().Play("DayMenuPopOut");
		DayMenuNightVisit.GetComponent.<Animation>().Play("DayMenuPopOut");
		DayMenuResume.GetComponent.<Animation>().Play("DayMenuPopOut");


}
