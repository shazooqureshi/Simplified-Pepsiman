using UnityEngine;
using System.Collections;

public class infinite_world : MonoBehaviour {

	// Use this for initialization
//	void Start () {
//	
//	}
	public float speed = -0.06f;
	// Update is called once per frame
	void Update () {
		float offset = Time.time * speed;
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (0, offset);
	}
}
