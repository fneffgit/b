using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class lvl_advance : MonoBehaviour {
	public bool is_button;
	public bool is_collide;
	public bool specific_room;
	public string room_name;

	void Start () {
		if (is_button) {
			Button btn = gameObject.GetComponent<Button> ();
			btn.onClick.AddListener(Advance);
		}
		if (is_collide) {
			//Nothing yet!
		}
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player")
		{
			Advance();
		}
	}

	void Advance(){
		int c = SceneManager.GetActiveScene().buildIndex;
		if (specific_room) {
			SceneManager.LoadScene(room_name);
		} else {
			if (c < SceneManager.sceneCountInBuildSettings) {
				SceneManager.LoadScene(c + 1);
			} 
		}
	}
}
