using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infinite : MonoBehaviour {

	public GameObject type1;
	public GameObject type2;
	public GameObject type3;
	public GameObject type4;
	public GameObject type5;
	public GameObject type6;

	void OnTriggerEnter(Collider col){
		Debug.Log (col.name);
		if (col.CompareTag ("Player")) {
			Vector3 posi;
			GameObject wow = transform.parent.gameObject;
			posi = new Vector3 (wow.gameObject.transform.position.x, wow.gameObject.transform.position.y, wow.gameObject.transform.position.z + 99.25f);
			int random = Random.Range (1, 7);
			if (random == 1) {
				Instantiate (type1, posi, Quaternion.identity);
			} else if (random == 2) {
				Instantiate (type2, posi, Quaternion.identity);
			} else if (random == 3) {
				Instantiate (type3, posi, Quaternion.identity);
			} else if (random == 4) {
				Instantiate (type4, posi, Quaternion.identity);
			} else if (random == 5) {
				Instantiate (type5, posi, Quaternion.identity);
			} else if (random == 6) {
				Instantiate (type6, posi, Quaternion.identity);
			} else {
				Debug.Log ("Game is broke");
			}
		}
	}

}
