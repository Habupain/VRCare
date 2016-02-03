using UnityEngine;
using System.Collections;

public class LoadMainMenu : MonoBehaviour {
	
	//the GUI texture  
    private GUITexture videoGUItex;  
    //the Movie texture  
  //  private MovieTexture mTex;  
    //the AudioSource  
    private AudioSource movieAS;  
    //the movie name inside the resources folder  
    public string movieName; 
	// Use this for initialization
	
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Awake()  
    {  
		GameObject maincam = GameObject.Find("Main Camera");
    	//get the attached GUITexture  
        videoGUItex = maincam.GetComponent<GUITexture>();  
        //get the attached AudioSource  
        movieAS = maincam.GetComponent<AudioSource>();  
        //load the movie texture from the resources folder  
        //mTex = (MovieTexture)Resources.Load(movieName);  
        //set the AudioSource clip to be the same as the movie texture audio clip  
       // movieAS.clip = mTex.audioClip;  
        //anamorphic fullscreen  
        videoGUItex.pixelInset = new Rect(Screen.width/2, Screen.height/2,0,0);  
    }  
	
	void OnMouseDown()
	{
		
		
		
		GameObject tohide = GameObject.Find("NightMenuLabel");
		if(tohide)
		{
			tohide.GetComponent<Renderer>().enabled = false;
		}
		tohide = GameObject.Find("NightMenuMainMenuChild");
		if(tohide)
		{
			tohide.GetComponent<Renderer>().enabled = false;
		}	
		tohide = GameObject.Find("NightMenuDayVisitChild");
		if(tohide)
		{
			tohide.GetComponent<Renderer>().enabled = false;
		}	
		tohide = GameObject.Find("NightMenuResumeChild");
		if(tohide)
		{
			tohide.GetComponent<Renderer>().enabled = false;
		}	
		
		tohide = GameObject.Find("MainMenuHazelWood");
		if(tohide)
		{
			tohide.GetComponent<Renderer>().enabled = false;
		}
		tohide = GameObject.Find("MainMenuMainMenu");
		if(tohide)
		{
			tohide.GetComponent<Renderer>().enabled = false;
		}
		tohide = GameObject.Find("MainMenuDayVisit");
		if(tohide)
		{
			tohide.GetComponent<Renderer>().enabled = false;
		}
		tohide = GameObject.Find("MainMenuNightVisit");
		if(tohide)
		{
			tohide.GetComponent<Renderer>().enabled = false;
		}
		tohide = GameObject.Find("MainMenuAbout");
		if(tohide)
		{
			tohide.GetComponent<Renderer>().enabled = false;
		}		
		tohide = GameObject.Find("MainMenuQuit");
		if(tohide)
		{
			tohide.GetComponent<Renderer>().enabled = false;
		}	
		
		tohide = GameObject.Find("DayMenuLabel");
		if(tohide)
		{
			tohide.GetComponent<Renderer>().enabled = false;
		}
		tohide = GameObject.Find("DayMenuMainMenuChild");
		if(tohide)
		{
			tohide.GetComponent<Renderer>().enabled = false;
		}	
		tohide = GameObject.Find("DayMenuNightVisitChild");
		if(tohide)
		{
			tohide.GetComponent<Renderer>().enabled = false;
		}	
		tohide = GameObject.Find("DayMenuResumeChild");
		if(tohide)
		{
			tohide.GetComponent<Renderer>().enabled = false;
		}	
		tohide = GameObject.Find("DayMenuMenu");
		if(tohide)
		{
			tohide.GetComponent<Renderer>().enabled = false;
		}
		tohide = GameObject.Find("NightMenuMenu");
		if(tohide)
		{
			tohide.GetComponent<Renderer>().enabled = false;
		}			
		
		
				//set the videoGUItex.texture to be the same as mTex  
	           // videoGUItex.texture = mTex;  
	            //Plays the movie  
	          //  mTex.Play();  
				//mTex.loop = true; 
	             
		   	 	Application.LoadLevelAsync("Brink_MainMenu");
	}
}
