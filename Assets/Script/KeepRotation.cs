using UnityEngine;
using System.Collections;




public class KeepRotation : MonoBehaviour {

    Quaternion initialTransform;

   

 

    void Awake()
    {
        initialTransform = GetComponent<RectTransform>().rotation;

    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<RectTransform>().rotation = initialTransform;
	}
}
