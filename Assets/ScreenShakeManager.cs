using UnityEngine;
using System.Collections;
using DG.Tweening;

public class ScreenShakeManager : MonoBehaviour {

    public static ScreenShakeManager Inst = null;
    Vector3 startPosition;

    void Awake()
    {
        if (Inst == null)
        {
            Inst = this;
        }
        else if (Inst != this )
        {
            Destroy(this);
        }
    }



	// Use this for initialization
	void Start () {
        startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A))
        {
            Shake(1);
        }
            
	
	}

    public void Shake(float strength, float randomness = 80f, float duration = 0.2f, int vibrato = 5)
    {
        Camera.main.DOShakePosition(duration, strength, vibrato, randomness);
        Invoke("ResetPosition", duration);
    }

    void ResetPosition()
    {
        transform.position = startPosition;
    }
}