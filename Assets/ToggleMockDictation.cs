using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMockDictation : MonoBehaviour
{

    GameObject dictation;
    
    public void Start()
    {
        dictation = GameObject.Find("DictationMock");
        dictation.SetActive(false);
    }

    public void OnShowText() {
        dictation.SetActive(!dictation.activeSelf);
    }
}
