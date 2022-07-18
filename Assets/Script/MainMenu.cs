using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void GoToMainMenu(){

		SceneManager.LoadScene ("MainMenu");
	}

	public void GoToARCamera(){

		SceneManager.LoadScene ("ARCamera");
	}

	public void GoToKuis(){

		SceneManager.LoadScene ("Kuis");
	}

	public void GoToLatihan(){

		SceneManager.LoadScene ("Latihan");
	}

	public void GoToPetunjuk(){

		SceneManager.LoadScene ("Panduan");
	}

    public void GoToMateri()
    {

        SceneManager.LoadScene("Materi");
    }

    public void GoToFO() { 
    
        SceneManager.LoadScene("KetFO");
    }

    public void GoToRJ45() {

        SceneManager.LoadScene("KetRJ45");
    }

    public void GoToConnector() {

        SceneManager.LoadScene("KetConnector");
    }

    public void GoToCrimping() {

        SceneManager.LoadScene("KetCrimping");
    }

    public void GoToHub() {

        SceneManager.LoadScene("KetHub");
    }

    public void GoToLanW(){

        SceneManager.LoadScene("KetLanW");
    }

    public void GoToLanCard() {

        SceneManager.LoadScene("KetLanCard");
    }

    public void GoToTester() {

        SceneManager.LoadScene("KetTester");
    }

    public void GoToModem() {

        SceneManager.LoadScene("KetModem");
    }

    public void GoToSwitch() {

        SceneManager.LoadScene("KetSwitch");
    }

    public void GoToRouter() {

        SceneManager.LoadScene("KetRouter");
    }

    public void GoToAP() {

        SceneManager.LoadScene("KetAP");
    }

    public void Mute(){
		AudioListener.pause = !AudioListener.pause;
	}
	public void ExitApplication (){
		Application.Quit ();
	}
}
