﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(GameObject.FindGameObjectsWithTag("Player").Length ==0)
        {
            SceneManager.LoadScene("GameOver");
        }
	}
}
