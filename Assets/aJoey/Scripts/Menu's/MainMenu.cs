﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public GameObject startText;

	// Use this for initialization
	void Start () {
        startText.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		if(GameObject.Find("Player").GetComponent<Jump>().gameStart == true)
        {
            startText.SetActive(false);
        }
        else
        {
            startText.SetActive(true);
        }
	}
}
