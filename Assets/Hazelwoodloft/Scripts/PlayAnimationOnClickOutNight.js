#pragma strict

var NightMenuLabel : Transform;
var NightMenuMainMenu : Transform;
var NightMenuDayVisit: Transform;
var NightMenuResume : Transform;

function Start () {

}

function OnMouseDown () {
		NightMenuLabel.GetComponent.<Animation>().Play("NightMenuPopOut");
		NightMenuMainMenu.GetComponent.<Animation>().Play("NightMenuPopOut");
		NightMenuDayVisit.GetComponent.<Animation>().Play("NightMenuPopOut");
		NightMenuResume.GetComponent.<Animation>().Play("NightMenuPopOut");


}

