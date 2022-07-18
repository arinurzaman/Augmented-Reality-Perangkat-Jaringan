using UnityEngine;
using System.Collections;
using Vuforia;

public class CekMarker : MonoBehaviour, ITrackableEventHandler {

	private TrackableBehaviour mTrackableBehaviour;
	public Texture cekMarker;

	private bool mShowGUIButton = false;
	private Rect mButtonRect = new Rect(50,50,120,60);

	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED)
		{
			mShowGUIButton = false;
		}
		else
		{
			mShowGUIButton = true;
		}
	}

	void OnGUI() {
		if (mShowGUIButton) {
			// draw the GUI button
			GUI.Label(new Rect((Screen.width/2)-150, (Screen.height/2)-150, 350, 320), cekMarker);
		}
	}
}
