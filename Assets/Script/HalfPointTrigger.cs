using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour {

	public GameObject FinishTrigger;
	public GameObject HalfLapTrigger;

	void OnTriggerEnter() {
		
			FinishTrigger.SetActive (true);
			HalfLapTrigger.SetActive (false);
	}
}
