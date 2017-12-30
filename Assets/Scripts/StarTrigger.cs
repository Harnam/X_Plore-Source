using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarTrigger : MonoBehaviour {

	void OnTriggerEnter(){
		PlayerPrefs.SetInt ("Stars", PlayerPrefs.GetInt ("Stars") + 1);
		Destroy (gameObject);
	}

}
