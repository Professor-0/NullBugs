using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SwitchScreen : MonoBehaviour {

	public void LoadUI () {
		SceneManager.LoadScene (sceneName:"Ui");
	}

	public void LoadVR() {
	    Screen.orientation = ScreenOrientation.LandscapeLeft;
		SceneManager.LoadScene (sceneName:"VR");
	}
}
