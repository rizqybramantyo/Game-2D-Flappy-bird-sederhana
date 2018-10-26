using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCrate : MonoBehaviour {

	public float speedX;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update (){
		transform.Translate (speedX, 0, 0);
		if (transform.position.x >= -8) {
			transform.Translate (-0.1f, 0, 0);
		} else {
			transform.Translate (16, Random.Range (-2, 4), 0);
			//if (transform.position.y > 3) {
			//	transform.Translate (0, Random.Range (-6, 0), 0);
			//} if (transform.position.y < -2){
			//	transform.Translate (0, Random.Range (0, 6), 0);
			//}else {
			//	transform.Translate (0, 0, 0);
			//}

			float randY = Random.Range (-2, 4);

			transform.localPosition = new Vector3 (transform.localPosition.x, randY, 0);
		}		
	}
}
