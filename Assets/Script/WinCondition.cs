using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class WinCondition : MonoBehaviour {

	//public GameObject LapsCounter;
	//public int LapsDone;

	public void ChangeScene()
	{
		//LapsDone += 1;
		//if (LapsDone == 1) {
			SceneManager.LoadScene (3);
		//}

		//LapsCounter.GetComponent<Text> ().text = "" + LapsDone;
	}
}
