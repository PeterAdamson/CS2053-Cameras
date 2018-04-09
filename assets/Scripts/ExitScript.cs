using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour {

	public GameController gameController;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerExit(Collider c)
	{
		if(c.gameObject.tag == "Player")
		{
			gameController.gameOver();
		}
		else if(c.gameObject.tag == "Computer")
		{
			gameController.incr();
			Destroy(c.gameObject);
		}
	}
}
