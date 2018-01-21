using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LapFinish : MonoBehaviour {

	public GameObject LapsCounter;
	public int LapsDone;


	void OnTriggerEnter(Collider Col)
	{
		if (Col.gameObject.tag == "Player")
		{
			GetComponent("LapsDone");
			Debug.Log("collide");
			//if (LapsDone == 1) 
			//{
			//	SceneManager.LoadScene(3);
			//}
		}
		LapsDone += 1;
		if (LapsDone == 1) {
			SceneManager.LoadScene (1);
		}

		LapsCounter.GetComponent<Text> ().text = "" + LapsDone;
	}
}
