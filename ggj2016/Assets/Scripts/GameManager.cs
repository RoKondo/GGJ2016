using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
    private int vida=100;

	void Awake () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad(gameObject);
	}
    public void dealDMG(int dmg)
    {
        this.vida -= dmg;
        Debug.Log(vida);
        if (this.vida <= 0)
            this.gameOver();
    }
    void gameOver()
    {

    }

}