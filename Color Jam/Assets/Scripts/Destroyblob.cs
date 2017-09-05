using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyblob : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){


		if (other.gameObject.tag == "Blob") {

			GetComponent<SpriteRenderer> ().enabled = false;
			GetComponent<BoxCollider2D> ().enabled = false;

		}
	}
}
