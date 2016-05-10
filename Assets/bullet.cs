using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

    public float damage;
    public float speed;
    public float lifeTime;
    public int shooterId;

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
        Debug.Log("bullet " +col.transform.tag);
        if(col.GetComponent(typeof(IDestroyable)))
        {
            IDestroyable target = col.GetComponent(typeof(IDestroyable)) as IDestroyable;
            target.applyDamage(damage);
            Destroy(gameObject);
        }
    }
}
