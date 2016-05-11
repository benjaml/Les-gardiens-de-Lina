using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

    public float damage;
    public float speed;
    public float lifeTime;
    public int shooterId;
    public float knockBackForce;

    // Use this for initialization
    void Start () {
        Destroy(gameObject, lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * speed * Time.deltaTime;
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.GetComponent(typeof(IDestroyable)) && col.transform.tag != "Player")
        {
            IDestroyable target = col.GetComponent(typeof(IDestroyable)) as IDestroyable;
            target.applyDamage(damage);
            Vector3 knockback = transform.forward;
            knockback *= knockBackForce;
            col.GetComponent<Rigidbody>().AddForce(knockback);
            Destroy(gameObject);
        }
    }
}
