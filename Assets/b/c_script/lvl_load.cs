using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;


public class lvl_load : MonoBehaviour {
	public bool is_button;
	public bool is_collide;

	void Start () {
		if (is_button) {
			Button btn = gameObject.GetComponent<Button> ();
			btn.onClick.AddListener(Load_Me);
		}
		if (is_collide) {
			//Nothing yet!
		}
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player")
		{
			Load_Me();
		}
	}

	void Load_Me(){
		int scene_tl = PlayerPrefs.GetInt("lvl");
		SceneManager.LoadScene(scene_tl);
		Debug.Log("Level loaded.");
	}
}
