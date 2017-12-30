using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {

	public GameObject player;
	Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = gameObject.transform.position - player.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		gameObject.transform.position = player.gameObject.transform.position + offset;
	}

}
