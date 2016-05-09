using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public float deadZone;
    private CharacterController controller;


	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");

        controller.Move(new Vector3(h, 0.0f, v) * speed * Time.deltaTime);

        
        v = Input.GetAxisRaw("VerticalLook");
        if (Mathf.Abs(v) < deadZone)
            v = 0f;
        h = Input.GetAxisRaw("HorizontalLook");
        if (Mathf.Abs(h) < deadZone)
            h = 0f;
        transform.LookAt(transform.position+new Vector3(h, 0.0f, v));
    }
}
