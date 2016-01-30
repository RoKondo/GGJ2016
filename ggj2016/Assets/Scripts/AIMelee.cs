using UnityEngine;
using System.Collections;

public class AIMelee : MonoBehaviour 
{
    public int speed = 3;
    public GameObject player;
    public float forca = 100;
    private Vector2 direcaoimp;
	void Update () 
    {
        Vector2 delta =  player.transform.position - this.transform.position;
        Vector2 direction = delta / delta.magnitude;

        this.transform.position += new Vector3(speed * direction.x * Time.deltaTime, speed * direction.y * Time.deltaTime, 0);
        if(forca>0)
        {
            player.transform.position += new Vector3(forca * direcaoimp.x * Time.deltaTime, forca * direcaoimp.y * Time.deltaTime, 0);
            if(forca<1)
            {
                forca = 0;
            }else
            {
                forca *=0.77f;
            }
        }
        	
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Vector2 delta = player.transform.position - this.transform.position;
            direcaoimp = delta / delta.magnitude;
            forca = 25;

        }
        
    }
}
