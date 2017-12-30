using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class processing : MonoBehaviour {

	GameObject player;
	Vector3 bug = new Vector3(0f,0f,-7f);

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Move");
	}
	
	// Update is called once per frame
	void Update () {
		if (player.gameObject.transform.position.z - gameObject.transform.position.z >= 87f) {
			Destroy (gameObject);
		}
		if (player.gameObject.transform.position == bug)
			Destroy (gameObject);
	}
}
