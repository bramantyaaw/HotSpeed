using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour {

	public void PlayGame(){
		SceneManager.LoadScene (2);
	}

	public void TrackSelect(){
		SceneManager.LoadScene (1);
	}

	public void MainMenu(){
		SceneManager.LoadScene (0);
	}
		
	public void Hotspeed(){
		SceneManager.LoadScene (2);
	}

	public void Hotspeed1(){
		SceneManager.LoadScene (3);
	}

	public void Hotspeed2(){
		SceneManager.LoadScene (4);
	}

	public void QuitGame(){
		Application.Quit ();
	}
}
