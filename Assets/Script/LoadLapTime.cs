﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour {

    public int MinCount;
    public int SecCount;
    public float MilCount;

    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilDisplay;


    // Use this for initialization
    void Start () {
		
        MinCount = PlayerPrefs.GetInt("MinSave");
		SecCount = PlayerPrefs.GetInt("SecSave");
		MilCount = PlayerPrefs.GetFloat("MilSave");

		MinDisplay.GetComponent<Text> ().text = "" + MinCount + ":";
		SecDisplay.GetComponent<Text> ().text = "" + SecCount + ".";
		MilDisplay.GetComponent<Text> ().text = "" + MilCount;
    }
}
