using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStarSpawn : MonoBehaviour {

	public GameObject starPrefab;

	// Use this for initialization
	void Start () {
		int random = Random.Range (1, 3);
		if (random == 1)
			Instantiate (starPrefab, gameObject.transform.position, Quaternion.identity);
		else
			return;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
