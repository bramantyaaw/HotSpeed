using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour {
	public Transform Canvas;
	public Transform PauseMenu;
	public Transform SoundsMenu;
	public Transform Player;
	SaveExit SaveGame;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Pause();
		}
	}

	public void Pause(){
		if (Canvas.gameObject.activeInHierarchy == false) 
		{
			if (PauseMenu.gameObject.activeInHierarchy == false) {
				PauseMenu.gameObject.SetActive (true);
				SoundsMenu.gameObject.SetActive (false);
			}
			Canvas.gameObject.SetActive (true);
			Time.timeScale = 0;
			Player.GetComponent<CarController> ().enabled = false;
			SaveGame = gameObject.GetComponent<SaveExit> ();
			SaveGame.SaveGameSettings (false);
		} else{
			Canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
			Player.GetComponent<CarController> ().enabled = true;
		}
	}

	public void Sounds(bool Open){
		if (Open) {
			SoundsMenu.gameObject.SetActive (true);
			PauseMenu.gameObject.SetActive (false);
		}
		if (!Open) {
			SoundsMenu.gameObject.SetActive (false);
			PauseMenu.gameObject.SetActive (true);
		}
	}
}

