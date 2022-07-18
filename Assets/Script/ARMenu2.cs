using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARMenu2 : MonoBehaviour {

	private float guiRatio;

	public GameObject sphere;
	public GameObject sphere1;
	public GameObject sphere2;
	public GameObject sphere3;
	public GameObject sphere4;
	public GameObject sphere5;
	public GameObject sphere6;
	public GameObject sphere7;
	public float kecepatanRotasi = 50f;
	bool statusRotasi = false;


	public void Rotasi ()
	{
		if (statusRotasi == false)
		{
			statusRotasi = true;
		}
		else
		{
			statusRotasi = false;
		}
	}

	void Update(){
		if (statusRotasi == true) {
			sphere.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
		}
		if (statusRotasi == true) {
			sphere1.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
		}
		if (statusRotasi == true) {
			sphere2.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
		}
		if (statusRotasi == true) {
			sphere3.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
		}
		if (statusRotasi == true) {
			sphere4.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
		}
		if (statusRotasi == true) {
			sphere5.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
		}
		if (statusRotasi == true) {
			sphere6.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
		}
		if (statusRotasi == true) {
			sphere7.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
		}
	}
}