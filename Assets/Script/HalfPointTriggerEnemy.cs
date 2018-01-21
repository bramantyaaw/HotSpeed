using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTriggerEnemy : MonoBehaviour {


	public GameObject FinishTriggerEnemy;
	public GameObject HalfLapTriggerEnemy;

	void OnTriggerEnter() {
		
			FinishTriggerEnemy.SetActive (true);
			HalfLapTriggerEnemy.SetActive (false);

	}
}
