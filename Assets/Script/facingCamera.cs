using UnityEngine;
using System.Collections;

public class facingCamera : MonoBehaviour
{
    public GameObject target;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 v = target.transform.position - transform.position;
        v.x = v.z = 0.0f;
        transform.LookAt(Camera.main.transform.position - v);
        transform.Rotate(180, 0, 0);
    }
}
