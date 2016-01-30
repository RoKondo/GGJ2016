using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public Vector2 direction;
    public float speed = 35;

	void Update () {
        this.transform.position +=  new Vector3(speed * direction.x * Time.deltaTime, speed * direction.y * Time.deltaTime, 0);
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {

        }
        Destroy(this.gameObject);
    }
    
}
