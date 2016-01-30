using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour
{

    public Vector2 direction;
    public float speed = 25;

    void Update()
    {
        this.transform.position += new Vector3(speed * direction.x * Time.deltaTime, speed * direction.y * Time.deltaTime, 0);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {

        }
        Destroy(this.gameObject);
    }

}
