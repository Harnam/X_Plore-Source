using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class playermove : MonoBehaviour {

	public bool restarting = false;
	public Texture[] textures;
	public Renderer rend;
	public int index;
	public AudioSource volume;
	public Slider slider;

	void Start(){
		slider.value = PlayerPrefs.GetInt ("Audio");
		Debug.Log (PlayerPrefs.GetInt ("HasPlayed"));
		rend = GetComponent<Renderer>();
		if (PlayerPrefs.GetInt ("HasPlayed") == 0) {
			PlayerPrefs.SetInt ("Audio", 100);
			PlayerPrefs.SetInt ("HasPlayed", 1);
		}
	}
		
	void Update () {
		int value = Mathf.RoundToInt(slider.value);
		PlayerPrefs.SetInt ("Audio", value);
		//Debug.Log (PlayerPrefs.GetInt ("Audio"));
		//float volval = PlayerPrefs.GetInt ("Audio") / 100;
		volume.volume = slider.value/100;
		index = PlayerPrefs.GetInt ("Skin");
		rend.material.mainTexture = textures[index];
		if (restarting) {
			gameObject.transform.localPosition = new Vector3 (0f, 0f, -1.21f);
			restarting = false;
		}
	}

	void FixedUpdate () {
		if (gameObject.transform.parent.gameObject.GetComponent<Rigidbody> ().isKinematic == false) {
			if (!(gameObject.transform.position.x == 14.25 || gameObject.transform.position.x == -14.25)) {
				float hori;
				hori = Input.GetAxis ("Horizontal");
				if (SystemInfo.deviceType == DeviceType.Handheld) {
					hori = CrossPlatformInputManager.GetAxis ("Horizontal");
					Debug.Log (hori);
				}
				gameObject.transform.position = new Vector3 (gameObject.transform.position.x + 50f * hori * Time.fixedDeltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
			}
		}
	}
}
