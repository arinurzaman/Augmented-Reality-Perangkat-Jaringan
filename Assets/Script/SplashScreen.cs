using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

	public float timer = 3;

	public void Update(){
		timer -= Time.deltaTime;
		if (timer > 0) {
			Debug.Log (timer);
		}else{
            SceneManager.LoadScene("MainMenu");
		}
	}
}
