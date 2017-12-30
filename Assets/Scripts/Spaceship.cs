using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spaceship : MonoBehaviour {

	float startpos;
	public ParticleSystem particle;
	public bool isPlaying = false;
	public float speed;
	public Text scoretext;
	public GameObject xplore;
	int score;
	Vector3 startposi;
	public Animator anim;
	public Text scortext;
	public Text highScoreText;
	public showScore showScoreScript;
	public GameObject controls;
	public Text starText;
	public GameObject shopCanvas;
	public GameObject settingsCanvas;
	public GameObject helpCanvas;
	public GameObject fpsCounterGameobject;
	public Text fpsCounterText;

	public void play(){
		gameObject.GetComponent<Rigidbody> ().isKinematic = true;
		anim.SetTrigger ("Start");
		gameObject.transform.position = startposi;
		StartCoroutine (waitasec ());
		DeleteAllObstacles ();
		gameObject.transform.GetChild (0).gameObject.GetComponent<playermove> ().restarting = true;
		xplore.GetComponent<Animator> ().SetTrigger ("Fade Out");
	}

	public void quit(){
		Application.Quit ();
	}

	// Use this for initialization
	void Start () {
		startposi = gameObject.transform.position;
		scoretext.enabled = false;
		xplore.SetActive (true);
		startpos = gameObject.transform.position.z;
		Debug.Log (Screen.width);
		controls.SetActive (false);
		gameObject.GetComponent<Rigidbody> ().isKinematic = true;
	}

	void OnCollisionEnter(Collision col){
		gameObject.GetComponent<Rigidbody> ().isKinematic = true;
		anim.SetTrigger ("Die");
		gameObject.transform.position = startposi;
		gameObject.transform.GetChild (0).gameObject.GetComponent<playermove> ().restarting = true;
		isPlaying = false;
		scortext.text = score.ToString ();
		if (score > PlayerPrefs.GetInt ("HighScore"))
			PlayerPrefs.SetInt ("HighScore", score);
		controls.SetActive (false);
		gameObject.transform.position = startposi;
		xplore.SetActive (true);
	}
		void Update(){
		if (PlayerPrefs.GetInt ("ScreenWidth") == 0 || PlayerPrefs.GetInt ("ScreenHeight") == 0) {
			PlayerPrefs.SetInt ("ScreenWidth", Screen.width);
			PlayerPrefs.SetInt ("ScreenHeight", Screen.height);
		}
		Screen.SetResolution (PlayerPrefs.GetInt("ScreenWidth"), PlayerPrefs.GetInt("ScreenHeight"), Screen.fullScreen);
		starText.text = PlayerPrefs.GetInt ("Stars").ToString ();
		highScoreText.text = (PlayerPrefs.GetInt ("HighScore")).ToString();
		if (isPlaying) {
			scoretext.enabled = true;
			xplore.SetActive (false);
		}
		if (!isPlaying) {
			scoretext.enabled = false;
			//xplore.SetActive (true);
		}
		if (isPlaying && !particle.isPlaying)
			particle.Play ();
		if (!isPlaying && particle.isPlaying)
			particle.Stop ();
		float curpos = gameObject.transform.position.z;
		score = Mathf.RoundToInt((curpos - startpos) / 50f);
		scoretext.text = score.ToString();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (isPlaying) {
			gameObject.transform.position = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + speed * Time.fixedDeltaTime);
		}
	}

	IEnumerator waitasec(){
		yield return new WaitForSeconds (1);
		isPlaying = true;
		showScoreScript.hasPlayed = true;
		gameObject.GetComponent<Rigidbody> ().isKinematic = false;
		if(SystemInfo.deviceType == DeviceType.Handheld)
			controls.SetActive (true);
		else
			controls.SetActive (false);
	}

	void DeleteAllObstacles(){
		GameObject[] wows = GameObject.FindGameObjectsWithTag ("Obstacle");
		foreach (GameObject wow in wows) {
			Destroy (wow);
		}
	}

	public void shop(){
		xplore.SetActive (false);
		shopCanvas.SetActive (true);
	}

	public void shopback(){
		shopCanvas.SetActive (false);
		xplore.SetActive (true);
	}

	public void settings(){
		xplore.SetActive (false);
		settingsCanvas.SetActive (true);
	}

	public void settingsback(){
		settingsCanvas.SetActive (false);
		xplore.SetActive (true);
	}

	public void help(){
		xplore.SetActive (false);
		helpCanvas.SetActive (true);
	}

	public void helpback(){
		helpCanvas.SetActive (false);
		xplore.SetActive (true);
	}

	public void quallvllow(){
		QualitySettings.SetQualityLevel (0);
	}

	public void quallvlmed(){
		QualitySettings.SetQualityLevel (3);
	}

	public void quallvlhigh(){
		QualitySettings.SetQualityLevel (5);
	}

	public void x800x600(){
		PlayerPrefs.SetInt ("ScreenWidth", 800);
		PlayerPrefs.SetInt ("ScreenHeight", 600);
	}

	public void x1280x720(){
		PlayerPrefs.SetInt ("ScreenWidth", 1280);
		PlayerPrefs.SetInt ("ScreenHeight", 720);
	}

	public void x1366x768(){
		PlayerPrefs.SetInt ("ScreenWidth", 1366);
		PlayerPrefs.SetInt ("ScreenHeight", 768);
	}

	public void x1920x1080(){
		PlayerPrefs.SetInt ("ScreenWidth", 1920);
		PlayerPrefs.SetInt ("ScreenHeight", 1080);
	}

}
