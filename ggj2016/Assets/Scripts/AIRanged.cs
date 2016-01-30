using UnityEngine;
using System.Collections;

public class AIRanged : MonoBehaviour {
    public int speed = 2;
    public GameObject player;
    public GameObject bullet;
    private Vector2 direction;
    private float magnitude;
    private int vida = 30;
	void Start()
    {
        InvokeRepeating("updateREnemy", 0, 1f);
    }
	void Update () {
        if(magnitude<7)
            this.transform.position -= new Vector3(speed * direction.x * Time.deltaTime, speed * direction.y * Time.deltaTime, 0);
	
	}

    void updateREnemy()
    {
        Vector2 delta = player.transform.position - this.transform.position;
        direction = delta / delta.magnitude;
        magnitude = delta.magnitude;
            Vector3 lookPos = new Vector3(direction.x, direction.y, 1);
            GameObject aux = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.AngleAxis((Mathf.Atan2(-lookPos.y, -lookPos.x) * Mathf.Rad2Deg), Vector3.forward));
            aux.GetComponent<EnemyBullet>().direction = direction;
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            
            vida -= coll.gameObject.GetComponent<Bullet>().dmg;
            
            if (vida <= 0)
                die();
        }
        
    }
    void die()
    {
        Destroy(this.gameObject);
    }
}
