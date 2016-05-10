using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public float deadZone;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");

        rb.MovePosition(transform.position + new Vector3(h, 0.0f, v) * speed * Time.deltaTime);

        
        v = Input.GetAxisRaw("VerticalLook");
        if (Mathf.Abs(v) < deadZone)
            v = 0f;
        h = Input.GetAxisRaw("HorizontalLook");
        if (Mathf.Abs(h) < deadZone)
            h = 0f;
        transform.LookAt(transform.position+new Vector3(h, 0.0f, v));
    }
}
