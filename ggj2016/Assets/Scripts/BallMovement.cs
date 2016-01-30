using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	private bool right;
	private bool left;
	private bool up;
	private bool down;

	void Update() {
		left = false;
		up = false;
		down = false;
		right = false;


		if (Input.GetKey (KeyCode.A)) {
			left = true;
            this.transform.position += new Vector3(-5 * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey (KeyCode.W)) {
			up = true;
            this.transform.position += new Vector3(0,5 * Time.deltaTime, 0);
        }
		if (Input.GetKey (KeyCode.S)) {
			down = true;
            this.transform.position += new Vector3(0,-5 * Time.deltaTime, 0);
        }
		if (Input.GetKey (KeyCode.D)) {
			right = true;
            this.transform.position += new Vector3(5 * Time.deltaTime, 0, 0);
        }



        //SPRITES
        if (up)
        {
            if (right)
            {
                //diagonal
            }
            else if (left)
            {
                //diagonal
            }
            else
            {
                //cima
            }
        }
        else if (down)
        {
            if (right)
            {
                //diagonal
            }
            else if (left)
            {
                //diagonal
            }
            else
            {
                //baixo
            }
        }
        else if (right)
        {
            //direita
        }
        else if (left)
        {
            //esquerda
        }
			
			
	}
    
}
