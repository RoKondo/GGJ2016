using UnityEngine;
using System.Collections;

public class Chamber : MonoBehaviour {
    
    public float activeTimer = 5;
    private float timeStamp = 0;
    private SpriteRenderer spriteRenderer;
        
    void Awake ()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    } 


	void Update () {
        if (Input.mouseScrollDelta != new Vector2(0, 0))
        {
            if (Input.mouseScrollDelta.y < 0)
            {
                spriteRenderer.enabled = true;
                timeStamp = 0;
                GetComponent<Animator>().SetTrigger("startSpin");
            }
            if (Input.mouseScrollDelta.y > 0)
            {
                spriteRenderer.enabled = true;
                timeStamp = 0;
                GetComponent<Animator>().SetTrigger("startSpinBackwards");
            }
        }

        if (spriteRenderer.enabled == true)
        {
            if (timeStamp > activeTimer || Input.GetMouseButtonDown(0))
            {
                spriteRenderer.enabled = false;
            }
            timeStamp += Time.deltaTime;
        }
    }
}
