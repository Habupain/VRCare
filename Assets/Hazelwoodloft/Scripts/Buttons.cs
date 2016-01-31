using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {
	
	//the GUI texture  
    private GUITexture videoGUItex;  
    //the Movie texture  
    private MovieTexture mTex;  
    //the AudioSource  
    private AudioSource movieAS;  
    //the movie name inside the resources folder  
    public string movieName; 
	// Use this for initialization
	
	bool hideall = false;
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Awake()  
    {  
    	//get the attached GUITexture  
        videoGUItex = this.GetComponent<GUITexture>();  
        //get the attached AudioSource  
        movieAS = this.GetComponent<AudioSource>();  
        //load the movie texture from the resources folder  
        mTex = (MovieTexture)Resources.Load(movieName);  
        //set the AudioSource clip to be the same as the movie texture audio clip  
        movieAS.clip = mTex.audioClip;  
        //anamorphic fullscreen  
        videoGUItex.pixelInset = new Rect(Screen.width/2, -Screen.height/2,0,0);  
    }  
	
	void OnGUI()
	{
		if(hideall == false)
		{
			if(GUI.Button(new Rect(768/2-250,100,200,100), "Day Scene")) {	
		    // Code goes here
				//set the videoGUItex.texture to be the same as mTex  
	            videoGUItex.texture = mTex;  
	            //Plays the movie  
	            mTex.Play();  
	            //plays the audio from the movie  
	            movieAS.Play();  
				hideall = true;
		   	 Application.LoadLevelAsync("Brink_Day_UI");
			}
	    
	    
			if(GUI.Button(new Rect(768/2+50,100,200,100), "Night Scene")) {
		    // Code goes here
				//set the videoGUItex.texture to be the same as mTex  
	            videoGUItex.texture = mTex;  
	            //Plays the movie  
	            mTex.Play();  
	            //plays the audio from the movie  
	            movieAS.Play(); 
				hideall = true;
		    Application.LoadLevelAsync("Brink_Night_UI");
		    }    
	    
		 	if(GUI.Button(new Rect(768/2-250,300,200,100), "Go To Website")) {
		    // Code goes here
		    Application.OpenURL("http://www.google.com/");
		    }     
	    
		 	if(GUI.Button(new Rect(768/2+50,300,200,100), "Exit")) {
		    // Code goes here
		  		Application.Quit();
		    }  
		}
	}
}
