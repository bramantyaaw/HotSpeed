using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LapLose : MonoBehaviour {

	public GameObject EnemyLapsCounter;
	public int EnemyLapsDone;

	void OnTriggerEnter(Collider ColEn)
	{
		//if (!ColEn.CompareTag ("EnemyCar"))
		//	return;
		
		if (ColEn.gameObject.tag == "EnemyCar")
		{
			GetComponent("EnemyLapsDone");
			//if (EnemyLapsDone ==1) 
			//{
			//	SceneManager.LoadScene(2);
			//}
		}
		EnemyLapsDone += 1;
		if (EnemyLapsDone == 1) {
			SceneManager.LoadScene (1);
		}

		EnemyLapsCounter.GetComponent<Text> ().text = "" + EnemyLapsDone;
	}
}
