using UnityEngine;
using System.Collections;

public class movement_obstacles : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public float speed = -0.06f;
	// Update is called once per frame
	void Update () {
		float offset = Time.time * speed;
		transform.Translate (new Vector3 (0, 0, offset));
		//		transform.Translate (Vector3.right * h * speed * Time.deltaTime);
	}
}
