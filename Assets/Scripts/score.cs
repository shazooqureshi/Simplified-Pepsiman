﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public Text scoreText;
	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + pepsican_rotation.score.ToString();
	}
}
