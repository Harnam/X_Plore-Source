using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showScore : MonoBehaviour {

	public bool hasPlayed = false;
	public GameObject scoreGameObject;
	
	// Update is called once per frame
	void Update () {
		if (hasPlayed)
			scoreGameObject.gameObject.SetActive (true);
		else
			scoreGameObject.gameObject.SetActive (false);
	}
}
