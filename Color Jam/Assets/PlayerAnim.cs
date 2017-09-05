using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.DownArrow)) {
			anim.SetBool ("Down", true);
		} else {
			anim.SetBool ("Down", false);
		}


		if (Input.GetKey (KeyCode.UpArrow)) {
			anim.SetBool ("Up", true);
		} else {
			anim.SetBool ("Up", false);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			anim.SetBool ("Right", true);
		} else {
			anim.SetBool ("Right", false);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			anim.SetBool ("Left", true);
		} else {
			anim.SetBool ("Left", false);
		}

	}
}
