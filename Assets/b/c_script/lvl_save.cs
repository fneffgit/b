using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;


public class lvl_save : MonoBehaviour {
	public bool is_button;
	public bool is_collide;

	void Start () {
		if (is_button) {
			Button btn = gameObject.GetComponent<Button> ();
			btn.onClick.AddListener(Save_Me);
		}
		if (is_collide) {
			//Nothing yet!
		}
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player")
		{
			Save_Me();
		}
	}

	void Save_Me(){
		PlayerPrefs.SetInt("lvl", SceneManager.GetActiveScene().buildIndex);
		Debug.Log("Level saved.");
	}
}
