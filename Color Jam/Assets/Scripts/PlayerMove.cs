using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMove : MonoBehaviour {

	public float speed;
	public Text winText;

	bool crossed;

	void Start (){
		winText.text = "";
	}


	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector2.right * speed);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-Vector2.right * speed);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector2.up * speed);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (-Vector2.up * speed);
		}
	}

	void OnTriggerEnter2D(Collider2D other){


		if (other.gameObject.tag == "Finish Line") {

			crossed = true; 
			Debug.Log ("true");
				
			//winText.text = "You Win!";
		}
			
		}

	void OnGUI () 
	{
		//If the boolean is active, display the text
		if (crossed == true) 
		{
			winText.text = "You Win!";
		}
	}
	}

