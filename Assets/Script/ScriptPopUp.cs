using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptPopUp : MonoBehaviour {
	public Canvas namaCanvas;
	public bool tampil = false;
	// Use this for initialization
	public void TampilPopUp () {
		if (tampil == false) {
			tampil = true;
			namaCanvas.enabled = true;
		} else if (tampil == true) {
			tampil = false;
			namaCanvas.enabled = false;
		}
		
	}

}
