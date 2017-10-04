using UnityEngine;
using System.Collections;
using System;

public class currentPlayer : MonoBehaviour {

	public static String title;
	public GUIText playerTitle;

	// Use this for initialization
	void Start () {
		playerTitle = GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {
		playerTitle.text = title;
	
	}
}
