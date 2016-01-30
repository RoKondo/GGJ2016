using UnityEngine;
using System.Collections;

public class AIRanged : MonoBehaviour {
    public int speed = 2;
    public GameObject player;
    public GameObject bullet;
    private Vector2 direction;
    private float magnitude;
	void Start()
    {
        InvokeRepeating("updateREnemy", 0, 0.5f);
    }
	void Update () {
        if(magnitude<7)
            this.transform.position -= new Vector3(speed * direction.x * Time.deltaTime, speed * direction.y * Time.deltaTime, 0);
	
	}

    private int nojeira = -1;
    void updateREnemy()
    {
        Vector2 delta = player.transform.position - this.transform.position;
        direction = delta / delta.magnitude;
        magnitude = delta.magnitude;
        if (nojeira == 1)
        {
            Vector3 lookPos = new Vector3(direction.x, direction.y, 1);
            GameObject aux = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.AngleAxis((Mathf.Atan2(-lookPos.y, -lookPos.x) * Mathf.Rad2Deg), Vector3.forward));
            aux.GetComponent<EnemyBullet>().direction = direction;
        }
        nojeira *= -1;
    }
}
