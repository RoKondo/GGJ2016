using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
    public GameObject bullet;

	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 delta = Camera.main.ScreenToWorldPoint(Input.mousePosition) - this.transform.position;
            Vector2 direction = delta / delta.magnitude;

            Vector3 lookPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)) - transform.position;
            GameObject aux = (GameObject) Instantiate(bullet, this.transform.position, Quaternion.AngleAxis((Mathf.Atan2(-lookPos.y, -lookPos.x) * Mathf.Rad2Deg), Vector3.forward));
            aux.GetComponent<Bullet>().direction = direction;
        }
    }
}
