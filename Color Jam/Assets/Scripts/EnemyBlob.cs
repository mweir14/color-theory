using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlob : MonoBehaviour {

	//private string myColor;

	void Start () 
	{
		//myColor = "red";
	}

	void OnTriggerEnter2D(Collider2D other){


		if (other.gameObject.tag == "Player") {

			GetComponent<SpriteRenderer> ().enabled = false;
			GetComponent<BoxCollider2D> ().enabled = false;

		}

		if (other.gameObject.tag == "Barrier") {

			Destroy(gameObject);
			//GetComponent<SpriteRenderer> ().enabled = false;
			//GetComponent<BoxCollider2D> ().enabled = false;

		}

	}
}
