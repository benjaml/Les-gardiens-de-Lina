using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Tutorial : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Submit"))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
