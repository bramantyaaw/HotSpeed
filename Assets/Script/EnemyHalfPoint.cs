using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHalfPoint : MonoBehaviour {

	public GameObject LoseTrigger;
	public GameObject EnemyHalfLap;

	void OnTriggerEnter(Collider ColEnemy){
		if (ColEnemy.gameObject.tag == "EnemyCar") {
			LoseTrigger.SetActive (true);
			EnemyHalfLap.SetActive (false);
		}
	}
}
