using UnityEngine;
using System.Collections;

public class KillZone : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Enemy")
        {
            col.GetComponent<Enemy>().Death();
        }
    }
}
