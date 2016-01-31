using UnityEngine;
using System.Collections;

public class IntroPlayMovie : MonoBehaviour {
	
	//the GUI texture  
    private GUITexture videoGUItex;  
    //the Movie texture  
    private MovieTexture mTex;  
    //the AudioSource  
    private AudioSource movieAS;  
    //the movie name inside the resources folder  
    public string movieName; 
	// Use this for initialization
	
	//the GUI texture  
    private GUITexture videoGUItex2;  
    //the Movie texture  
    private MovieTexture mTex2;  
    //the AudioSource  
    private AudioSource movieAS2;  
    //the movie name inside the resources folder  
    public string movieNameTransition; 
	// Use this for initialization	
	private bool once; 
	
	void Start () {
		
		GameObject maincam = GameObject.Find("Main Camera");
    	//get the attached GUITexture  
        videoGUItex = maincam.GetComponent<GUITexture>();  
        //get the attached AudioSource  
        movieAS = maincam.GetComponent<AudioSource>();  
        //load the movie texture from the resources folder  
        mTex = (MovieTexture)Resources.Load(movieName);  
        //set the AudioSource clip to be the same as the movie texture audio clip  
        movieAS.clip = mTex.audioClip;  
        //anamorphic fullscreen  
        videoGUItex.pixelInset = new Rect(Screen.width/2, -Screen.height/2,0,0);  
		mTex2 = (MovieTexture)Resources.Load(movieNameTransition);  
		
		//set the videoGUItex.texture to be the same as mTex  
	    videoGUItex.texture = mTex;  
	    //Plays the movie  

	    mTex.Play();  
		
		//mTex.
		//mTex.loop = true; 
		
	    //plays the audio from the movie  
	    movieAS.Play();
		
		once = false;
		

		//Application.LoadLevelAsync("Brink_Night_UI");
	}
	
	// Update is called once per frame
	void Update () {
		if(mTex.isPlaying)
		{

		}
		else
			if(once == false)
		{
			once = true;
			GameObject maincam = GameObject.Find("Main Camera");
	    	//get the attached GUITexture  
	        videoGUItex2 = maincam.GetComponent<GUITexture>();  
	        //get the attached AudioSource  
	        movieAS2 = maincam.GetComponent<AudioSource>();  
	        //set the AudioSource clip to be the same as the movie texture audio clip  
	        movieAS2.clip = mTex2.audioClip;  
	        //anamorphic fullscreen  
	        videoGUItex2.pixelInset = new Rect(Screen.width/2, -Screen.height/2-1,0,0);  			
			//set the videoGUItex.texture to be the same as mTex  
	    	videoGUItex2.texture = mTex2;  
	    	//Plays the movie  
	   	 	mTex2.Play();  
			mTex2.loop = true;
	    	//plays the audio from the movie  
	   		movieAS2.Play(); 
			Application.LoadLevelAsync("Brink_MainMenu");
		}
	}
	
	void Awake()  
    {  

    }  
	
	void OnMouseDown()
	{

	}
	

}
