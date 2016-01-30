using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

    public GameObject bullet;
    private bool isShooting =false;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&& !isShooting)
        {
            Vector2 delta = Camera.main.ScreenToWorldPoint(Input.mousePosition) - this.transform.position;
            Vector2 direction = delta / delta.magnitude;

            Vector3 lookPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)) - transform.position;
            GameObject aux = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.AngleAxis((Mathf.Atan2(-lookPos.y, -lookPos.x) * Mathf.Rad2Deg), Vector3.forward));
            aux.GetComponent<Bullet>().direction = direction;
            isShooting = true;
            Invoke("freeShoot",0.5f);

        }
    }
    void freeShoot()
    {
        isShooting = false;
    }
}
