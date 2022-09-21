using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class CameraScript : MonoBehaviour
{
    private bool camAvailable;
    private WebCamTexture backCam;
    // Start is called before the first frame update
    void Start()
    {
				
		Application.RequestUserAuthorization(UserAuthorization.WebCam);
		if (Application.HasUserAuthorization(UserAuthorization.WebCam))
		{
			Debug.Log("webcam found");
		}
		else
		{
			Debug.Log("webcam not found");
		}
        WebCamTexture webcamTexture = new WebCamTexture();
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.mainTexture = webcamTexture;
		webcamTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
