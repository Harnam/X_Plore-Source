using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour {

	public GameObject equip0;
	public GameObject equip1;
	public GameObject equip2;
	public GameObject equip3;
	public GameObject equip4;

	public GameObject equipped0;
	public GameObject equipped1;
	public GameObject equipped2;
	public GameObject equipped3;
	public GameObject equipped4;

	public GameObject buy0;
	public GameObject buy1;
	public GameObject buy2;
	public GameObject buy3;
	public GameObject buy4;

	void Update(){
		if (PlayerPrefs.GetInt ("1DONE") == 1 && PlayerPrefs.GetInt ("Skin") == 1) {
			equipped1.SetActive (true);
			buy1.SetActive (false);
			equip1.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("2DONE") == 1 && PlayerPrefs.GetInt ("Skin") == 2) {
			equipped2.SetActive (true);
			buy2.SetActive (false);
			equip2.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("3DONE") == 1 && PlayerPrefs.GetInt ("Skin") == 3) {
			equipped3.SetActive (true);
			buy3.SetActive (false);
			equip3.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("4DONE") == 1 && PlayerPrefs.GetInt ("Skin") == 4) {
			equipped4.SetActive (true);
			buy4.SetActive (false);
			equip4.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("0DONE") == 1 && PlayerPrefs.GetInt ("Skin") == 0) {
			equipped0.SetActive (true);
			buy0.SetActive (false);
			equip0.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("0DONE") == 0) {
			buy0.SetActive (true);
			equip0.SetActive (false);
			equipped0.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("1DONE") == 0) {
			buy1.SetActive (true);
			equip1.SetActive (false);
			equipped1.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("2DONE") == 0) {
			buy2.SetActive (true);
			equip2.SetActive (false);
			equipped2.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("3DONE") == 0) {
			buy3.SetActive (true);
			equip3.SetActive (false);
			equipped3.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("4DONE") == 0) {
			buy4.SetActive (true);
			equip4.SetActive (false);
			equipped4.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("0DONE") == 1 && PlayerPrefs.GetInt ("Skin") != 0) {
			equipped0.SetActive (false);
			buy0.SetActive (false);
			equip0.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("1DONE") == 1 && PlayerPrefs.GetInt ("Skin") != 1) {
			equipped1.SetActive (false);
			buy1.SetActive (false);
			equip1.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("2DONE") == 1 && PlayerPrefs.GetInt ("Skin") != 2) {
			equipped2.SetActive (false);
			buy2.SetActive (false);
			equip2.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("3DONE") == 1 && PlayerPrefs.GetInt ("Skin") != 3) {
			equipped3.SetActive (false);
			buy3.SetActive (false);
			equip3.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("4DONE") == 1 && PlayerPrefs.GetInt ("Skin") != 4) {
			equipped4.SetActive (false);
			buy4.SetActive (false);
			equip4.SetActive (true);
		}
	}

	public void equip(int index){
		PlayerPrefs.SetInt ("Skin", index);
	}

	void Start(){
		PlayerPrefs.SetInt ("0DONE", 1);
	}

	public void buyskin(int index){
		if (index == 0) {
			if (PlayerPrefs.GetInt ("Stars") > 0) {
				PlayerPrefs.SetInt ("0DONE", 1);
				PlayerPrefs.SetInt ("Stars", PlayerPrefs.GetInt ("Stars") - 0);
				PlayerPrefs.SetInt ("Skin", index);
			}
		} else if (index == 1) {
			if (PlayerPrefs.GetInt ("Stars") > 100) {
				PlayerPrefs.SetInt ("1DONE", 1);
				PlayerPrefs.SetInt ("Stars", PlayerPrefs.GetInt ("Stars") - 100);
				PlayerPrefs.SetInt ("Skin", index);
			}
		} else if (index == 2) {
			if (PlayerPrefs.GetInt ("Stars") > 200) {
				PlayerPrefs.SetInt ("2DONE", 1);
				PlayerPrefs.SetInt ("Stars", PlayerPrefs.GetInt ("Stars") - 200);
				PlayerPrefs.SetInt ("Skin", index);
			}
		} else if (index == 3) {
			if (PlayerPrefs.GetInt ("Stars") > 500) {
				PlayerPrefs.SetInt ("3DONE", 1);
				PlayerPrefs.SetInt ("Stars", PlayerPrefs.GetInt ("Stars") - 500);
				PlayerPrefs.SetInt ("Skin", index);
			}
		} else if (index == 4) {
			if (PlayerPrefs.GetInt ("Stars") > 1000) {
				PlayerPrefs.SetInt ("4DONE", 1);
				PlayerPrefs.SetInt ("Stars", PlayerPrefs.GetInt ("Stars") - 1000);
				PlayerPrefs.SetInt ("Skin", index);
			}
		} else {
			return;
		}
	}

}
