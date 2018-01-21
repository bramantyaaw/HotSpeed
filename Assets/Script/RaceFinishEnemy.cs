using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinishEnemy : MonoBehaviour {

	public GameObject EnemyCar;
	//public GameObject EnemyFinishCam;
	//public GameObject EnemyViewModes;
	//public GameObject LevelMusic;
	public AudioSource EnemyFinishMusic;
	public GameObject CompleteTrig;

	void OnTriggerEnter(Collider Col){
		if (Col.tag == "EnemyCar") {
			this.GetComponent<BoxCollider> ().enabled = false;
			CompleteTrig.SetActive (false);
			EnemyCar.SetActive (false);
			CarController.m_Topspeed = 0.0f;
			EnemyCar.GetComponent<CarController> ().enabled = false;
			EnemyCar.GetComponent<CarAIControl> ().enabled = false;
			EnemyCar.SetActive (true);
			//EnemyFinishCam.SetActive (true);
			//LevelMusic.SetActive (false);
			//EnemyViewModes.SetActive (false);
			EnemyFinishMusic.Play ();
		}
	}
}
