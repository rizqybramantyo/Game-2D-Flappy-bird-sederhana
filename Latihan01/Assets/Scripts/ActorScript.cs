using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ActorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public int score = 0;
	public Text textScore;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)|| Input.GetMouseButtonDown(0)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 3);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			GetComponent<Rigidbody2D> ().transform.Translate (0,0.1f, 0);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			GetComponent<Rigidbody2D> ().transform.Translate (0,-0.1f, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			GetComponent<Rigidbody2D> ().transform.Translate (0.1f, 0,0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody2D> ().transform.Translate (-0.1f, 0,0);
		}

	}



	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name.Contains ("Crate")) {
			SceneManager.LoadScene ("Level 02");
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		//Melihat di console nama yang bertabrakan
		//Debug.Log (col.gameObject.name);

		if (col.gameObject.name == "Sensor") {
			score += 1;
			textScore.text = score.ToString ();
			//Penambahan score
		}
	}
}
