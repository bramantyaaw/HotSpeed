using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveExit : MonoBehaviour {
	public Transform Player;

	// Use this for initialization
	void Awake () {
		//Player.position = new Vector3 (PlayerPrefs.GetFloat ("x"), PlayerPrefs.GetFloat ("y"), PlayerPrefs.GetFloat ("z"));
		//Player.eulerAngles = new Vector3 (0, PlayerPrefs.GetFloat ("Cam_y"), 0);
	}
	
	// Update is called once per frames
	public void SaveGameSettings (bool Quit) {
		PlayerPrefs.SetFloat ("x", Player.position.x);
		PlayerPrefs.SetFloat ("y", Player.position.y);
		PlayerPrefs.SetFloat ("z", Player.position.z);
		PlayerPrefs.SetFloat ("Cam_y", Player.eulerAngles.y);
		if (Quit) {
			Time.timeScale = 1;
			SceneManager.LoadScene (0);
		}
	}
}
