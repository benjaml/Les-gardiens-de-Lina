using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    
    public float speed;
    public float rotationSpeed;
    public float deadZone;
    Rigidbody rb;

    public GameObject head;
    public GameObject tank;

    int playerId;
    float vLook;
    float hLook;

    // Use this for initialization
    void Start () {
        playerId = GetComponent<Player>().playerId;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float v = XInput.instance.getYStickLeft(playerId);
        float h = XInput.instance.getXStickLeft(playerId);

        rb.MovePosition(transform.position + new Vector3(h, 0.0f, v) * speed * Time.deltaTime);

        
        if (Mathf.Abs(XInput.instance.getYStickRight(playerId)) > deadZone)
            vLook = XInput.instance.getYStickRight(playerId);
        if (Mathf.Abs(XInput.instance.getXStickRight(playerId)) > deadZone)
            hLook = XInput.instance.getXStickRight(playerId);

        Vector3 relativePos = head.transform.position + new Vector3(hLook, 0.0f, vLook) * -1f - head.transform.position;
        head.transform.rotation = Quaternion.Slerp(head.transform.rotation, Quaternion.LookRotation(relativePos), rotationSpeed * Time.deltaTime);
        //head.transform.LookAt(head.transform.position+new Vector3(h, 0.0f, v)*-1f);
    }
}
