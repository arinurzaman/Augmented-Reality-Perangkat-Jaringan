using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("Skor", 0);
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().text = PlayerPrefs.GetInt ("Skor").ToString ();
	}
}
