using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public int speed = 1;
	public int rotationSpeed = 1;
	public int force = 1;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
//		float v = Input.GetAxis ("Vertical");
//		transform.Translate (Vector3.forward * v * speed * Time.deltaTime);
		float h = Input.GetAxis ("Horizontal");
		transform.Translate (Vector3.right * h * speed * Time.deltaTime);

//		float j = Input.GetAxis ("Jump");
//		transform.Translate (Vector3.up * j * speed * Time.deltaTime);

		Rigidbody rb = GetComponent<Rigidbody> ();
		if (Input.GetButtonDown ("Jump")) {
			rb.AddForce (new Vector3 (0, force, 0), ForceMode.Impulse);
		}

		if (Input.GetButtonDown ("Fire3")) {
			transform.Rotate (new Vector3 (1, 0, 0) * 90);
		}
//		transform.Rotate(new Vector3(0,1,0) * h * rotationSpeed);
	}
}
