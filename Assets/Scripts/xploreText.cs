using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xploreText : MonoBehaviour {

	void OnEnable () {
		Animator anim = gameObject.GetComponent<Animator> ();
		anim.SetTrigger ("Fade In");
	}

}
