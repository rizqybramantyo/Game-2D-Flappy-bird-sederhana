using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x >= -8) {
			transform.Translate (-0.04f, 0, 0);
		} else {
			transform.Translate (16, 0, 0);
		}
	}
}
